---
title: "Walkthrough: Implementing Code Snippets"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - vs-ide-sdk
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: adbc5382-d170-441c-9fd0-80faa1816478
caps.latest.revision: 21
translation.priority.mt: 
  - de-de
  - ja-jp
---
# Walkthrough: Implementing Code Snippets
You can create code snippets and include them in an editor extension so that users of the extension can add them to their own code.  
  
 A code snippet is a fragment of code or other text that can be incorporated in a file. To view all snippets that have been registered for particular programming languages, on the **Tools** menu, click **Code Snippet Manager**. To insert a snippet in a file, right-click where you want the snippet, click **Insert Snippet** or **Surround With**, locate the snippet you want, and then double-click it. Press TAB or SHIFT+TAB to modify the relevant parts of the snippet and then press ENTER or ESC to accept it. For more information, see [Creating and Using IntelliSense Code Snippets](../vs140/code-snippets.md).  
  
 A code snippet is contained in an XML file that has the .snippet file name extension. A snippet can contain fields that are highlighted after the snippet is inserted so that the user can find and change them. A snippet file also provides information for the **Code Snippet Manager** so that it can display the snippet name in the correct category. For information about the snippet schema, see [Code Snippets Schema Reference](../vs140/code-snippets-schema-reference.md).  
  
 This walkthrough teaches how to accomplish these tasks:  
  
1.  Create and register code snippets for a specific language.  
  
2.  Add the **Insert Snippet** command to a shortcut menu.  
  
3.  Implement snippet expansion.  
  
 This walkthrough is based on [Walkthrough: Displaying Statement Completion](../vs140/walkthrough--displaying-statement-completion.md).  
  
## Prerequisites  
 Starting in Visual Studio 2015, you do not install the Visual Studio SDK from the download center. It is included as an optional feature in Visual Studio setup. You can also install the VS SDK later on. For more information, see [Installing the Visual Studio SDK](../vs140/installing-the-visual-studio-sdk.md).  
  
## Creating and Registering Code Snippets  
 Typically, code snippets are associated with a registered language service. However, you do not have to implement a <xref:Microsoft.VisualStudio.Package.LanguageService?qualifyHint=False> to register code snippets. Instead, just specify a GUID in the snippet index file and then use the same GUID in the <xref:Microsoft.VisualStudio.Shell.ProvideLanguageCodeExpansionAttribute?qualifyHint=False> that you add to your project.  
  
 The following steps demonstrate how to create code snippets and associate them with a specific GUID.  
  
1.  Create the following directory structure:  
  
     **%InstallDir%\TestSnippets\Snippets\1033\\**  
  
     where *%InstallDir%* is the Visual Studio installation folder. (Although this path is typically used to install code snippets, you can specify any path.)  
  
2.  In the \1033\ folder, create an .xml file and name it **TestSnippets.xml**. (Although this name is typically used for a snippet index file, you can specify any name as long as it has an .xml file name extension.) Add the following text, and then delete the placeholder GUID and add your own.  
  
    ```xml  
    <?xml version="1.0" encoding="utf-8" ?>  
    <SnippetCollection>  
        <Language Lang="TestSnippets" Guid="{00000000-0000-0000-0000-000000000000}">  
            <SnippetDir>  
                <OnOff>On</OnOff>  
                <Installed>true</Installed>  
                <Locale>1033</Locale>  
                <DirPath>%InstallRoot%\TestSnippets\Snippets\%LCID%\</DirPath>  
                <LocalizedName>Snippets</LocalizedName>  
            </SnippetDir>  
        </Language>  
    </SnippetCollection>  
    ```  
  
3.  Create a file in the snippet folder, name it **test**`.snippet`, and then add the following text:  
  
    ```xml  
    <?xml version="1.0" encoding="utf-8" ?>  
    <CodeSnippets  xmlns="http://schemas.microsoft.com/VisualStudio/2005/CodeSnippet">  
        <CodeSnippet Format="1.0.0">  
            <Header>  
                <Title>Test replacement fields</Title>  
                <Shortcut>test</Shortcut>  
                <Description>Code snippet for testing replacement fields</Description>  
                <Author>MSIT</Author>  
                <SnippetTypes>  
                    <SnippetType>Expansion</SnippetType>  
                </SnippetTypes>  
            </Header>  
            <Snippet>  
                <Declarations>  
                    <Literal>  
                      <ID>param1</ID>  
                        <ToolTip>First field</ToolTip>  
                        <Default>first</Default>  
                    </Literal>  
                    <Literal>  
                        <ID>param2</ID>  
                        <ToolTip>Second field</ToolTip>  
                        <Default>second</Default>  
                    </Literal>  
                </Declarations>  
                <References>  
                   <Reference>  
                       <Assembly>System.Windows.Forms.dll</Assembly>  
                   </Reference>  
                </References>  
                <Code Language="TestSnippets">  
                    <![CDATA[MessageBox.Show("$param1$");  
         MessageBox.Show("$param2$");]]>  
                </Code>    
            </Snippet>  
        </CodeSnippet>  
    </CodeSnippets>  
    ```  
  
 The following steps show how to register the code snippets.  
  
#### To register code snippets for a specific GUID  
  
1.  Open the **CompletionTest** project. For information about how to create this project, see [Walkthrough: Displaying Statement Completion](../vs140/walkthrough--displaying-statement-completion.md).  
  
2.  In the project, add references to the following assemblies:  
  
    -   Microsoft.VisualStudio.TextManager.Interop  
  
    -   Microsoft.VisualStudio.TextManager.Interop.8.0  
  
    -   microsoft.msxml  
  
3.  In the project, open the source.extension.vsixmanifest file.  
  
4.  Make sure that the **Assets** tab contains a **VsPackage** content type and that **Project** is set to the name of the project.  
  
5.  Select the CompletionTest project and in the Properties window set **Generate Pkgdef File** to **true**. Save the project.  
  
6.  Add a static `SnippetUtilities` class to the project.  
  
     [!code[VSSDKCompletionTest#22](../vs140/codesnippet/CSharp/walkthrough--implementing-code-snippets_1.cs)]
[!code[VSSDKCompletionTest#22](../vs140/codesnippet/VisualBasic/walkthrough--implementing-code-snippets_1.vb)]
  
  
7.  In the SnippetUtilities class, define a GUID and give it the value that you used in the SnippetsIndex.xml file.  
  
     [!code[VSSDKCompletionTest#23](../vs140/codesnippet/CSharp/walkthrough--implementing-code-snippets_2.cs)]
[!code[VSSDKCompletionTest#23](../vs140/codesnippet/VisualBasic/walkthrough--implementing-code-snippets_2.vb)]
  
  
8.  Add the <xref:Microsoft.VisualStudio.Shell.ProvideLanguageCodeExpansionAttribute?qualifyHint=False> to the `TestCompletionHandler` class. This attribute can be added to any public or internal (non-static) class in the project. (You may have to add a `using` statement for the Microsoft.VisualStudio.Shell namespace.)  
  
     [!code[VSSDKCompletionTest#24](../vs140/codesnippet/CSharp/walkthrough--implementing-code-snippets_3.cs)]
[!code[VSSDKCompletionTest#24](../vs140/codesnippet/VisualBasic/walkthrough--implementing-code-snippets_3.vb)]
  
  
9. Build and run the project. In the experimental instance of Visual Studio that starts when the project is run, the snippet you just registered should be displayed in the **Code Snippets Manager** under the **TestSnippets** language.  
  
## Adding the Insert Snippet Command to the Shortcut Menu  
 The **Insert Snippet** command is not included on the shortcut menu for a text file. Therefore, you must enable the command.  
  
#### To add the Insert Snippet command to the shortcut menu  
  
1.  Open the `TestCompletionCommandHandler` class file.  
  
     Because this class implements <xref:Microsoft.VisualStudio.OLE.Interop.IOleCommandTarget?qualifyHint=False>, you can activate the **Insert Snippet** command in the <xref:Microsoft.VisualStudio.OLE.Interop.IOleCommandTarget.QueryStatus?qualifyHint=False> method. Before you enable the command, check that this method is not being called inside an automation function because when the **Insert Snippet** command is clicked, it will display the snippet picker user interface (UI).  
  
     [!code[VSSDKCompletionTest#25](../vs140/codesnippet/CSharp/walkthrough--implementing-code-snippets_4.cs)]
[!code[VSSDKCompletionTest#25](../vs140/codesnippet/VisualBasic/walkthrough--implementing-code-snippets_4.vb)]
  
  
2.  Build and run the project. In the experimental instance, open a file that has the .zzz file name extension and then right-click anywhere in it. The **Insert Snippet** command should appear on the shortcut menu.  
  
## Implementing Snippet Expansion in the Snippet Picker UI  
 This section shows how to implement code snippet expansion so that the snippet picker UI is displayed when **Insert Snippet** is clicked on the shortcut menu. A code snippet is also expanded when a user types the code-snippet shortcut and then presses TAB.  
  
 To display the snippet picker UI and to enable navigation and post-insertion snippet acceptance, use the <xref:Microsoft.VisualStudio.OLE.Interop.IOleCommandTarget.Exec?qualifyHint=False> method. The insertion itself is handled by the <xref:Microsoft.VisualStudio.TextManager.Interop.IVsExpansionClient.OnItemChosen?qualifyHint=False> method.  
  
 The implementation of code snippet expansion uses legacy <xref:Microsoft.VisualStudio.TextManager.Interop?qualifyHint=False> interfaces. When you translate from the current editor classes to the legacy code, remember that the legacy interfaces use a combination of line numbers and column numbers to specify locations in a text buffer, but the current classes use one index. Therefore, if a buffer has three lines each of which has ten characters (plus a newline, which counts as 1 character), the fourth character on the third line is at position 27 in the current implementation, but it is at line 2, position 3 in the old implementation.  
  
#### To implement snippet expansion  
  
1.  To the file that contains the `TestCompletionCommandHandler` class, add the following `using` statements.  
  
     [!code[VSSDKCompletionTest#26](../vs140/codesnippet/CSharp/walkthrough--implementing-code-snippets_5.cs)]
[!code[VSSDKCompletionTest#26](../vs140/codesnippet/VisualBasic/walkthrough--implementing-code-snippets_5.vb)]
  
  
2.  Make the `TestCompletionCommandHandler` class implement the <xref:Microsoft.VisualStudio.TextManager.Interop.IVsExpansionClient?qualifyHint=False> interface.  
  
     [!code[VSSDKCompletionTest#27](../vs140/codesnippet/CSharp/walkthrough--implementing-code-snippets_6.cs)]
[!code[VSSDKCompletionTest#27](../vs140/codesnippet/VisualBasic/walkthrough--implementing-code-snippets_6.vb)]
  
  
3.  In the `TestCompletionCommandHandlerProvider` class, import the <xref:Microsoft.VisualStudio.Text.Operations.ITextStructureNavigatorSelectorService?qualifyHint=False>.  
  
     [!code[VSSDKCompletionTest#28](../vs140/codesnippet/CSharp/walkthrough--implementing-code-snippets_7.cs)]
[!code[VSSDKCompletionTest#28](../vs140/codesnippet/VisualBasic/walkthrough--implementing-code-snippets_7.vb)]
  
  
4.  Add some private fields for the code expansion interfaces and the <xref:Microsoft.VisualStudio.TextManager.Interop.IVsTextView?qualifyHint=False>.  
  
     [!code[VSSDKCompletionTest#29](../vs140/codesnippet/CSharp/walkthrough--implementing-code-snippets_8.cs)]
[!code[VSSDKCompletionTest#29](../vs140/codesnippet/VisualBasic/walkthrough--implementing-code-snippets_8.vb)]
  
  
5.  In the constructor of the `TestCompletionCommandHandler` class, set the following fields.  
  
     [!code[VSSDKCompletionTest#30](../vs140/codesnippet/CSharp/walkthrough--implementing-code-snippets_9.cs)]
[!code[VSSDKCompletionTest#30](../vs140/codesnippet/VisualBasic/walkthrough--implementing-code-snippets_9.vb)]
  
  
6.  To display the snippet picker when the user clicks the **Insert Snippet** command, add the following code to the <xref:Microsoft.VisualStudio.OLE.Interop.IOleCommandTarget.Exec?qualifyHint=False> method. (To make this explanation more readable, the Exec() code that is used for statement completion is not shown; instead, blocks of code are added to the existing method.) Add the following block of code after the code that checks for a character.  
  
     [!code[VSSDKCompletionTest#31](../vs140/codesnippet/CSharp/walkthrough--implementing-code-snippets_10.cs)]
[!code[VSSDKCompletionTest#31](../vs140/codesnippet/VisualBasic/walkthrough--implementing-code-snippets_10.vb)]
  
  
7.  If a snippet has fields that can be navigated, the expansion session is kept open until the expansion is explicitly accepted; if the snippet has no fields, the session is closed and is returned as `null` by the <xref:Microsoft.VisualStudio.TextManager.Interop.IVsExpansionManager.InvokeInsertionUI?qualifyHint=False> method. In the <xref:Microsoft.VisualStudio.OLE.Interop.IOleCommandTarget.Exec?qualifyHint=False> method, after the snippet picker UI code that you added in the previous step, add the following code to handle snippet navigation (when the user presses TAB or SHIFT+TAB after snippet insertion).  
  
     [!code[VSSDKCompletionTest#32](../vs140/codesnippet/CSharp/walkthrough--implementing-code-snippets_11.cs)]
[!code[VSSDKCompletionTest#32](../vs140/codesnippet/VisualBasic/walkthrough--implementing-code-snippets_11.vb)]
  
  
8.  To insert the code snippet when the user types the corresponding shortcut and then presses TAB, add code to the <xref:Microsoft.VisualStudio.OLE.Interop.IOleCommandTarget.Exec?qualifyHint=False> method. The private method that inserts the snippet will be shown in a later step. Add the following code after the navigation code that you added in the previous step.  
  
     [!code[VSSDKCompletionTest#33](../vs140/codesnippet/CSharp/walkthrough--implementing-code-snippets_12.cs)]
[!code[VSSDKCompletionTest#33](../vs140/codesnippet/VisualBasic/walkthrough--implementing-code-snippets_12.vb)]
  
  
9. Implement the methods of the <xref:Microsoft.VisualStudio.TextManager.Interop.IVsExpansionClient?qualifyHint=False> interface. In this implementation, the only methods of interest are <xref:Microsoft.VisualStudio.TextManager.Interop.IVsExpansionClient.EndExpansion?qualifyHint=False> and <xref:Microsoft.VisualStudio.TextManager.Interop.IVsExpansionClient.OnItemChosen?qualifyHint=False>. The other methods should just return <xref:Microsoft.VisualStudio.VSConstants.S_OK?qualifyHint=False>.  
  
     [!code[VSSDKCompletionTest#34](../vs140/codesnippet/CSharp/walkthrough--implementing-code-snippets_13.cs)]
[!code[VSSDKCompletionTest#34](../vs140/codesnippet/VisualBasic/walkthrough--implementing-code-snippets_13.vb)]
  
  
10. Implement the <xref:Microsoft.VisualStudio.TextManager.Interop.IVsExpansionClient.OnItemChosen?qualifyHint=False> method. The helper method that actually inserts the expansions will be covered in a later step. The <xref:Microsoft.VisualStudio.TextManager.Interop.TextSpan?qualifyHint=False> provides line and column information, which you can get from the <xref:Microsoft.VisualStudio.TextManager.Interop.IVsTextView?qualifyHint=False>.  
  
     [!code[VSSDKCompletionTest#35](../vs140/codesnippet/CSharp/walkthrough--implementing-code-snippets_14.cs)]
[!code[VSSDKCompletionTest#35](../vs140/codesnippet/VisualBasic/walkthrough--implementing-code-snippets_14.vb)]
  
  
11. The following private method inserts a code snippet, based either on the shortcut or on the title and path. It then calls the <xref:Microsoft.VisualStudio.TextManager.Interop.IVsExpansion.InsertNamedExpansion?qualifyHint=False> method with the snippet.  
  
     [!code[VSSDKCompletionTest#36](../vs140/codesnippet/CSharp/walkthrough--implementing-code-snippets_15.cs)]
[!code[VSSDKCompletionTest#36](../vs140/codesnippet/VisualBasic/walkthrough--implementing-code-snippets_15.vb)]
  
  
## Building and Testing Code Snippet Expansion  
 You can test whether snippet expansion works in your project.  
  
1.  Build the solution. When you run this project in the debugger, a second instance of Visual Studio is instantiated.  
  
2.  Open a text file and type some text.  
  
3.  Right-click somewhere in the text and then click **Insert Snippet**.  
  
4.  The snippet picker UI should appear with a pop-up that says **Test replacement fields**. Double-click the pop-up.  
  
     The following snippet should be inserted.  
  
    ```  
    MessageBox.Show("first");  
    MessageBox.Show("second");  
    ```  
  
     Do not press ENTER or ESC.  
  
5.  Press TAB and SHIFT+TAB to toggle between "first" and "second".  
  
6.  Accept the insertion by pressing either ENTER or ESC.  
  
7.  In a different part of the text, type "test" and then press TAB. Because "test" is the code-snippet shortcut, the snippet should be inserted again.  
  
## Next Steps