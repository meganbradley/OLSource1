---
title: "Support for Code Snippets in a Legacy Language Service"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: na
ms.topic: "article"
helpviewer_keywords: 
  - "snippets, supporting in language services"
  - "code snippets, supporting in language services [managed package framework]"
  - "language services [managed package framework], supporting code snippets"
ms.assetid: 7490325b-acee-4c2d-ac56-1cd5db1a1083
caps.latest.revision: 32
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# Support for Code Snippets in a Legacy Language Service
A code snippet is a piece of code that is inserted into the source file. The snippet itself is an XML-based template with a set of fields. These fields are highlighted after the snippet is inserted and can have different values depending on the context in which the snippet is inserted. Immediately after the snippet is inserted, the language service can format the snippet.  
  
 The snippet is inserted in a special edit mode that allows the fields of the snippet to be navigated by using the TAB key. The fields can support IntelliSense-style drop-down menus. The user commits the snippet to the source file by typing either the ENTER or the ESC key. To learn more about snippets, please see [Creating and Using IntelliSense Code Snippets](../vs140/code-snippets.md).  
  
 Legacy language services are implemented as part of a VSPackage, but the newer way to implement language service features is to use MEF extensions. To find out more, see [Walkthrough: Implementing Code Snippets](../vs140/walkthrough--implementing-code-snippets.md).  
  
> [!NOTE]
>  We recommend that you begin to use the new editor API as soon as possible. This will improve the performance of your language service and let you take advantage of new editor features.  
  
## Managed Package Framework Support for Code Snippets  
 The managed package framework (MPF) supports most snippet functionality, from reading the template to inserting the snippet and enabling the special edit mode. Support is managed through the \<xref:Microsoft.VisualStudio.Package.ExpansionProvider*> class.  
  
 When the \<xref:Microsoft.VisualStudio.Package.Source*> class is instantiated, the \<xref:Microsoft.VisualStudio.Package.LanguageService.CreateExpansionProvider*> method in the \<xref:Microsoft.VisualStudio.Package.LanguageService*> class is called to obtain an \<xref:Microsoft.VisualStudio.Package.ExpansionProvider*> object (note that the base \<xref:Microsoft.VisualStudio.Package.LanguageService*> class always returns a new \<xref:Microsoft.VisualStudio.Package.ExpansionProvider*> object for each \<xref:Microsoft.VisualStudio.Package.Source*> object).  
  
 The MPF does not support expansion functions. An expansion function is a named function that is embedded in a snippet template and returns one or more values to be placed in a field. The values are returned by the language service itself through an \<xref:Microsoft.VisualStudio.Package.ExpansionFunction*> object. The \<xref:Microsoft.VisualStudio.Package.ExpansionFunction*> object must be implemented by the language service to support expansion functions.  
  
## Providing Support for Code Snippets  
 To enable support for code snippets, you must provide or install the snippets and you must provide the means for the user to insert those snippets. There are three steps to enabling support for code snippets:  
  
1.  Installing the snippet files.  
  
2.  Enabling code snippets for your language service.  
  
3.  Invoking the \<xref:Microsoft.VisualStudio.Package.ExpansionProvider*> object.  
  
### Installing the Snippet Files  
 All snippets for a language are stored as templates in XML files, typically one snippet template per file. For details on the XML schema used for code snippet templates, see [Code Snippets Schema Reference](../vs140/code-snippets-schema-reference.md). Each snippet template is identified with a language ID. This language ID is specified in the registry and is put into the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> attribute of the \<Code> tag in the template.  
  
 There are typically two locations where snippet template files are stored: 1) where your language was installed and 2) in the user's folder. These locations are added to the registry so that the Visual Studio **Code Snippets Manager** can find the snippets. The user's folder is where snippets created by the user are stored.  
  
 The typical folder layout for the installed snippet template files looks like this: *[InstallRoot]*\\*[TestLanguage]*\Snippets\\*[LCID]*\Snippets.  
  
 *[InstallRoot]* is the folder your language is installed in.  
  
 *[TestLanguage]* is the name of your language as a folder name.  
  
 *[LCID]* is the locale ID. This is how localized versions of your snippets are stored. For example, the locale ID for English is 1033, so *[LCID]* is replaced by 1033.  
  
 One additional file must be supplied and that is an index file, typically called SnippetsIndex.xml or ExpansionsIndex.xml (you can use any valid filename ending in .xml). This file is typically stored in the *[InstallRoot]*\\*[TestLanguage]* folder and specifies the exact location of the snippets folder as well as the language ID and GUID of the language service that uses the snippets. The exact path of the index file is put into the registry as described later in "Installing the Registry Entries". Here is an example of a SnippetsIndex.xml file:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 The \<Language> tag specifies the language ID (the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> attribute) and the language service GUID.  
  
 This example assumes you have installed your language service in the Visual Studio installation folder. The %LCID% is replaced with the user's current locale ID. Multiple \<SnippetDir> tags can be added, one for each different directory and locale. In addition, a snippet folder can contain subfolders, each of which is identified in the index file with the \<SnippetSubDir> tag that is embedded in a \<SnippetDir> tag.  
  
 Users can also create their own snippets for your language. These are typically stored in the user's settings folder, for example *[TestDocs]*\Code Snippets\\*[TestLanguage]*\Test Code Snippets, where *[TestDocs]* is the location of the user's settings folder for Visual Studio.  
  
 The following substitution elements can be placed in the path stored in the \<DirPath> tag in the index file.  
  
|Element|Description|  
|-------------|-----------------|  
|%LCID%|Locale ID.|  
|%InstallRoot%|Root installation folder for Visual Studio, for example, C:\Program Files\Microsoft Visual Studio 8.|  
|%ProjDir%|Folder containing the current project.|  
|%ProjItem%|Folder containing the current project item.|  
|%TestDocs%|Folder in the user's settings folder, for example, C:\Documents and Settings\\*[username]*\My Documents\Visual Studio\8.|  
  
### Enabling Code Snippets for Your Language Service  
 You can enable code snippets for your language service by adding the \<xref:Microsoft.VisualStudio.Shell.ProvideLanguageCodeExpansionAttribute*> attribute to your VSPackage (see [Registering a Language Service (Managed Package Framework)](../vs140/registering-a-legacy-language-service1.md) for details). The \<xref:Microsoft.VisualStudio.Shell.ProvideLanguageCodeExpansionAttribute.ShowRoots*> and \<xref:Microsoft.VisualStudio.Shell.ProvideLanguageCodeExpansionAttribute.SearchPaths*> parameters are optional, but you should include the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> named parameter in order to inform the **Code Snippets Manager** of the location of your snippets.  
  
 The following is an example of how to use this attribute:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Calling the Expansion Provider  
 The language service controls the insertion of any code snippet, as well as the way insertion is invoked.  
  
## Calling the Expansion Provider for Code Snippets  
 There are two ways to invoke the expansion provider: by using a menu command or by using a shortcut from a completion list.  
  
### Inserting a Code Snippet by using a Menu Command  
 To use a menu command to display the snippet browser, you add a menu command and then call the [M:Microsoft.VisualStudio.Package.ExpansionProvider.DisplayExpansionBrowser(Microsoft.VisualStudio.TextManager.Interop.IVsTextView,System.String,System.String\[\],System.Boolean,System.String\[\],System.Boolean)](assetId:///M:Microsoft.VisualStudio.Package.ExpansionProvider.DisplayExpansionBrowser(Microsoft.VisualStudio.TextManager.Interop.IVsTextView,System.String,System.String[],System.Boolean,System.String[],System.Boolean)?qualifyHint=False&autoUpgrade=True) method in the \<xref:Microsoft.VisualStudio.Package.ExpansionProvider*> interface in response to that menu command.  
  
1.  Add a command and a button to your .vsct file. You can find instructions for doing so in [Walkthrough: Creating a Menu Command By Using the Visual Studio Package Template](../Topic/Walkthrough:%20Creating%20a%20Menu%20Command%20By%20Using%20the%20Visual%20Studio%20Package%20Template_deleted.md).  
  
2.  Derive a class from the \<xref:Microsoft.VisualStudio.Package.ViewFilter*> class and override the \<xref:Microsoft.VisualStudio.Package.ViewFilter.QueryCommandStatus*> method to indicate support for the new menu command. This example always enables the menu command.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
3.  Override the \<xref:Microsoft.VisualStudio.Package.ViewFilter.HandlePreExec*> method in the \<xref:Microsoft.VisualStudio.Package.ViewFilter*> class to obtain the \<xref:Microsoft.VisualStudio.Package.ExpansionProvider*> object and call the [M:Microsoft.VisualStudio.Package.ExpansionProvider.DisplayExpansionBrowser(Microsoft.VisualStudio.TextManager.Interop.IVsTextView,System.String,System.String\[\],System.Boolean,System.String\[\],System.Boolean)](assetId:///M:Microsoft.VisualStudio.Package.ExpansionProvider.DisplayExpansionBrowser(Microsoft.VisualStudio.TextManager.Interop.IVsTextView,System.String,System.String[],System.Boolean,System.String[],System.Boolean)?qualifyHint=False&autoUpgrade=True) method on that object.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
     The following methods in the \<xref:Microsoft.VisualStudio.Package.ExpansionProvider*> class are called by Visual Studio in the given order during the process of inserting the snippet:  
  
4.  \<xref:Microsoft.VisualStudio.Package.ExpansionProvider.OnItemChosen*>  
  
5.  [M:Microsoft.VisualStudio.Package.ExpansionProvider.IsValidKind(Microsoft.VisualStudio.TextManager.Interop.IVsTextLines,Microsoft.VisualStudio.TextManager.Interop.TextSpan\[\],System.String,System.Int32@)](assetId:///M:Microsoft.VisualStudio.Package.ExpansionProvider.IsValidKind(Microsoft.VisualStudio.TextManager.Interop.IVsTextLines,Microsoft.VisualStudio.TextManager.Interop.TextSpan[],System.String,System.Int32@)?qualifyHint=False&autoUpgrade=True)  
  
6.  \<xref:Microsoft.VisualStudio.Package.ExpansionProvider.OnBeforeInsertion*>  
  
7.  [M:Microsoft.VisualStudio.Package.ExpansionProvider.FormatSpan(Microsoft.VisualStudio.TextManager.Interop.IVsTextLines,Microsoft.VisualStudio.TextManager.Interop.TextSpan\[\])](assetId:///M:Microsoft.VisualStudio.Package.ExpansionProvider.FormatSpan(Microsoft.VisualStudio.TextManager.Interop.IVsTextLines,Microsoft.VisualStudio.TextManager.Interop.TextSpan[])?qualifyHint=False&autoUpgrade=True)  
  
8.  \<xref:Microsoft.VisualStudio.Package.ExpansionProvider.OnAfterInsertion*>  
  
     After the \<xref:Microsoft.VisualStudio.Package.ExpansionProvider.OnAfterInsertion*> method is called, the snippet has been inserted and the \<xref:Microsoft.VisualStudio.Package.ExpansionProvider*> object is in a special edit mode used for modifying a snippet that has just been inserted.  
  
### Inserting a code snippet by using a shortcut  
 Implementation of a shortcut from a completion list is much more involved than implementing a menu command. You must first add snippet shortcuts to the IntelliSense word completion list. Then you must detect when a snippet shortcut name has been inserted as a result of completion. Finally, you must obtain the snippet title and path using the shortcut name and pass that information to the \<xref:Microsoft.VisualStudio.Package.ExpansionProvider.InsertNamedExpansion*> method on the \<xref:Microsoft.VisualStudio.Package.ExpansionProvider*> method.  
  
 To add snippet shortcuts to the word completion list, add them to the \<xref:Microsoft.VisualStudio.Package.Declarations*> object in your \<xref:Microsoft.VisualStudio.Package.AuthoringScope*> class. You must make sure you can identify the shortcut as a snippet name. For an example, see [How to: Get a List of Installed Code Snippets](../vs140/walkthrough--getting-a-list-of-installed-code-snippets--legacy-implementation-.md).  
  
 You can detect the insertion of the code snippet shortcut in the \<xref:Microsoft.VisualStudio.Package.Declarations.OnAutoComplete*> method of the \<xref:Microsoft.VisualStudio.Package.Declarations*> class. Because the snippet name has already been inserted into the source file, it must be removed when the expansion is inserted. The \<xref:Microsoft.VisualStudio.Package.ExpansionProvider.InsertNamedExpansion*> method takes a span that describes the point of insertion for the snippet; if the span includes the entire snippet name in the source file, that name is replaced by the snippet.  
  
 Here is a version of a \<xref:Microsoft.VisualStudio.Package.Declarations*> class that handles snippet insertion given a shortcut name. Other methods in the \<xref:Microsoft.VisualStudio.Package.Declarations*> class have been omitted for clarity. Note that the constructor of this class takes a \<xref:Microsoft.VisualStudio.Package.LanguageService*> object. This can be passed in from your version of the \<xref:Microsoft.VisualStudio.Package.AuthoringScope*> object (for example, your implementation of the \<xref:Microsoft.VisualStudio.Package.AuthoringScope*> class might take the \<xref:Microsoft.VisualStudio.Package.LanguageService*> object in its constructor and pass that object on to your <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> class constructor).  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 When the language service gets the shortcut name, it calls the \<xref:Microsoft.VisualStudio.Package.ExpansionProvider.FindExpansionByShortcut*> method to obtain the filename and code snippet title. The language service then calls the \<xref:Microsoft.VisualStudio.Package.ExpansionProvider.InsertNamedExpansion*> method in the \<xref:Microsoft.VisualStudio.Package.ExpansionProvider*> class to insert the code snippet. The following methods are called by Visual Studio in the given order in the \<xref:Microsoft.VisualStudio.Package.ExpansionProvider*> class during the process of inserting the snippet:  
  
1.  [M:Microsoft.VisualStudio.Package.ExpansionProvider.IsValidKind(Microsoft.VisualStudio.TextManager.Interop.IVsTextLines,Microsoft.VisualStudio.TextManager.Interop.TextSpan\[\],System.String,System.Int32@)](assetId:///M:Microsoft.VisualStudio.Package.ExpansionProvider.IsValidKind(Microsoft.VisualStudio.TextManager.Interop.IVsTextLines,Microsoft.VisualStudio.TextManager.Interop.TextSpan[],System.String,System.Int32@)?qualifyHint=False&autoUpgrade=True)  
  
2.  \<xref:Microsoft.VisualStudio.Package.ExpansionProvider.OnBeforeInsertion*>  
  
3.  [M:Microsoft.VisualStudio.Package.ExpansionProvider.FormatSpan(Microsoft.VisualStudio.TextManager.Interop.IVsTextLines,Microsoft.VisualStudio.TextManager.Interop.TextSpan\[\])](assetId:///M:Microsoft.VisualStudio.Package.ExpansionProvider.FormatSpan(Microsoft.VisualStudio.TextManager.Interop.IVsTextLines,Microsoft.VisualStudio.TextManager.Interop.TextSpan[])?qualifyHint=False&autoUpgrade=True)  
  
4.  \<xref:Microsoft.VisualStudio.Package.ExpansionProvider.OnAfterInsertion*>  
  
 For more information on getting a list of installed code snippets for your language service, see [How to: Get a List of Installed Code Snippets](../vs140/walkthrough--getting-a-list-of-installed-code-snippets--legacy-implementation-.md).  
  
## Implementing the ExpansionFunction Class  
 An expansion function is a named function that is embedded in a snippet template and returns one or more values to be placed in a field. In order to support expansion functions in your language service, you must derive a class from the \<xref:Microsoft.VisualStudio.Package.ExpansionFunction*> class and implement the \<xref:Microsoft.VisualStudio.Package.ExpansionFunction.GetCurrentValue*> method. You must then override the \<xref:Microsoft.VisualStudio.Package.LanguageService.CreateExpansionFunction*> method in the \<xref:Microsoft.VisualStudio.Package.LanguageService*> class to return a new instantiation of your version of the \<xref:Microsoft.VisualStudio.Package.ExpansionFunction*> class for each expansion function you support. If you support a list of possible values from an expansion function, you must also override the \<xref:Microsoft.VisualStudio.Package.ExpansionFunction.GetIntellisenseList*> method in the \<xref:Microsoft.VisualStudio.Package.ExpansionFunction*> class to return a list of those values.  
  
 An expansion function that takes arguments or needs to access other fields should not be associated with an editable field, as the expansion provider might not be fully initialized by the time the expansion function is called. As a result, the expansion function is not able to obtain the value of its arguments or any other field.  
  
### Example  
 Here is an example of how a simple expansion function called <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> might be implemented. This expansion function appends a number to a base class name each time the expansion function is instantiated (which corresponds to each time the associated code snippet is inserted).  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
## See Also  
 [Language Service Features (Managed Package Framework)](../vs140/legacy-language-service-features1.md)   
 [Registering a Language Service (Managed Package Framework)](../vs140/registering-a-legacy-language-service1.md)   
 [Creating and Using Intellisense Code Snippets](../vs140/code-snippets.md)   
 [How to: Get a List of Installed Code Snippets](../vs140/walkthrough--getting-a-list-of-installed-code-snippets--legacy-implementation-.md)