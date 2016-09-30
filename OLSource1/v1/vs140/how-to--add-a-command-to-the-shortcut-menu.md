---
title: "How to: Add a Command to the Shortcut Menu"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-tfs-dev14"
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: "article"
helpviewer_keywords: 
  - "Domain-Specific Language Tools, walkthroughs"
  - "walkthroughs [Domain-Specific Language Tools]"
ms.assetid: cd550399-05fc-4dbf-be4c-f5094bb752ce
caps.latest.revision: 26
---
# How to: Add a Command to the Shortcut Menu
You can add menu commands to your domain-specific language (DSL) so that your users can perform tasks that are specific to your DSL. The commands appear on the context (shortcut) menu when users right-click on the diagram. You can define a command so that it only appears in the menu in specific circumstances. For example, you can make the command visible only when the user clicks specific types of element, or elements in specific states.  
  
 In summary, the steps are performed in the DslPackage project, as follows:  
  
1.  [Declare the command in Commands.vsct](#VSCT)  
  
2.  [Update the package version number in Package.tt](#version). You have to do this whenever you change Commands.vsct  
  
3.  [Write methods in the CommandSet class](#CommandSet) to make the command visible and to define what you want the command to do.  
  
 For samples, see the [Visualization and Modeling SDK website](http://go.microsoft.com/fwlink/?LinkID=185579).  
  
> [!NOTE]
>  You can also modify the behavior of some existing commands such as Cut, Paste, Select All, and Print by overriding methods in CommandSet.cs. For more information, see [How to: Modify an Existing Command](../vs140/how-to--modify-a-standard-menu-command-in-a-domain-specific-language.md).  
  
## Defining a Command using MEF  
 Managed Extension Framework (MEF) provides an alternative method of defining menu commands on the diagram menu. Its primary purpose is to enable a DSL to be extended by you or by other parties. Users can choose to install just the DSL, or can install both the DSL and extensions. However, MEF also reduces the work of defining shortcut menu commands, after the initial work to enable MEF on the DSL.  
  
 Use the method in this topic if:  
  
1.  You want to define menu commands on menus other than the right-click shortcut menu.  
  
2.  You want to define specific groupings of commands in the menu.  
  
3.  You do not want to enable others to extend the DSL with their own commands.  
  
4.  You only want to define one command.  
  
 Otherwise, consider using the MEF method to define commands. For more information, see [Extend your DSL using MEF](../vs140/extend-your-dsl-by-using-mef.md).  
  
##  \<a name="VSCT">\</a> Declare the Command in Commands.Vsct  
 Menu commands are declared in DslPackage\Commands.vsct. These definitions specify the labels of the menu items and where they appear on the menus.  
  
 The file that you edit, Commands.vsct, imports definitions from several .h files, which are located in the directory *Visual Studio SDK install path*\VisualStudioIntegration\Common\Inc. It also includes GeneratedVsct.vsct, which is generated from your DSL definition.  
  
 For more information about .vsct files, see [Visual Studio Command Table (.Vsct) Files](../vs140/visual-studio-command-table--.vsct--files.md).  
  
#### To add the command  
  
1.  In **Solution Explorer**, under the **DslPackage** project, open Commands.vsct.  
  
2.  In the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> element, define one or more buttons and a group. A *button* is an item on the menu. A *group* is a section in the menu. To define these items, add the following elements:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
    > [!NOTE]
    >  Each button or group is identified by a GUID and an integer ID. You can create several groups and buttons with the same GUID. However, they must have different IDs. The GUID names and ID names are translated to actual GUIDs and numeric IDs in the <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> node.  
  
3.  Add a visibility constraint for the command so that it is loaded only in the context of your domain-specific language. For more information, see [VisibilityConstraints Element](../vs140/visibilityconstraints-element.md).  
  
     To do this, add the following elements in the <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> element after the <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> element.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
4.  Define the names that you used for the guids and ids. To do this, add a <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> element in the <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> element after the <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> element.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
5.  Replace <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> with a GUID that identifies your groups and menu items. To obtain a new GUID, use the **Create GUID** tool on the **Tools** menu.  
  
    > [!NOTE]
    >  If you add more groups or menu items, you can use the same GUID. However, you must use new values for the <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>.  
  
6.  In the code you have copied from this procedure, replace each occurrence of the following strings with your own strings:  
  
    -   <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
  
    -   <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
  
    -   <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>  
  
    -   <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>  
  
##  \<a name="version">\</a> Update the Package Version in Package.tt  
 Whenever you add or change a command, update the <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> parameter of the \<xref:Microsoft.VisualStudio.Shell.ProvideMenuResourceAttribute*> that is applied to the package class before you release the new version of your domain-specific language.  
  
 Because the package class is defined in a generated file, update the attribute in the text template file that generates the Package.cs file.  
  
#### To update the Package.tt file  
  
1.  In **Solution Explorer**, in the **DslPackage** project, in the **GeneratedCode** folder, open the Package.tt file.  
  
2.  Locate the <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> attribute.  
  
3.  Increment the <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> parameter of the attribute, which is the second parameter. If you want, you can write the parameter name explicitly to remind you of its purpose. For example:  
  
     <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>  
  
##  \<a name="CommandSet">\</a> Define the Behavior of the Command  
 Your DSL already has some commands that are implemented in a partial class that is declared in DslPackage\GeneratedCode\CommandSet.cs. To add new commands, you must extend this class by creating a new file that contains a partial declaration of the same class. The name of the class is usually *\<YourDslName>*<CodeContentPlaceHolder>26\</CodeContentPlaceHolder>. It is useful to begin by verifying the name of the class and inspecting its contents.  
  
 The command set class is derived from \<xref:Microsoft.VisualStudio.Modeling.Shell.CommandSet*>.  
  
#### To extend the CommandSet class  
  
1.  In Solution Explorer, in the DslPackage project, open the GeneratedCode folder and then look under CommandSet.tt and open its generated file CommandSet.cs. Note the namespace and the name of the first class that is defined there. For example, you might see:  
  
     <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>  
  
     <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>  
  
2.  In **DslPackage**, create a folder that is named **Custom Code**. In this folder, create a new class file that is named <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>.  
  
3.  In the new file, write a partial declaration that has the same namespace and name as the generated partial class. For example:  
  
     <CodeContentPlaceHolder>30\</CodeContentPlaceHolder>  
  
     <CodeContentPlaceHolder>31\</CodeContentPlaceHolder>  
  
     **Note** If you used the class template to create the new file, you must correct both the namespace and the class name.  
  
### Extend the Command Set class  
 Your command set code will typically need to import the following namespaces:  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Adjust the namespace and the class name to match those in the generated CommandSet.cs:  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 You have to define two methods, one to determine when the command will be visible on the context menu, and the other to perform the command. These methods are not overrides; instead, you register them in a list of commands.  
  
### Define when the command will be visible  
 For each command, define an <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> method that determines whether the command will appear on the menu, and whether it will be enabled or greyed out. Set the <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> properties of the <CodeContentPlaceHolder>35\</CodeContentPlaceHolder>, as shown in the following example. This method is called in order to construct the shortcut menu every time that the user right-clicks the diagram, so it must work quickly.  
  
 In this example, the command is visible only when the user has selected a particular type of shape, and is enabled only when at least one of the selected elements is in a particular state. The example is based on the Class Diagram DSL template, and ClassShape and ModelClass are types that are defined in the DSL:  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 The following fragments are frequently useful in OnStatus methods:  
  
-   <CodeContentPlaceHolder>36\</CodeContentPlaceHolder>. The shape that the user right-clicked is always included in this list. If the user clicks on a blank part of the diagram, the Diagram is the only member of the list.  
  
-   <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> - <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> if the user clicked a blank part of the diagram.  
  
-   <CodeContentPlaceHolder>39\</CodeContentPlaceHolder>  
  
-   <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> - the user did not select multiple objects  
  
-   <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> - the shape or diagram that the user right-clicked  
  
-   <CodeContentPlaceHolder>42\</CodeContentPlaceHolder> - the model element represented by a shape.  
  
 As a general guideline, make the <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> property depend on what is selected, and make the <CodeContentPlaceHolder>44\</CodeContentPlaceHolder> property depend on the state of the selected elements.  
  
 An OnStatus method should not change the state of the Store.  
  
### Define what the command does  
 For each command, define an <CodeContentPlaceHolder>45\</CodeContentPlaceHolder> method that performs the required action when the user clicks the menu command.  
  
 If you make changes to model elements, you must do so inside a transaction. For more information, see [How to Create and Update model elements](../vs140/how-to--modify-a-standard-menu-command-in-a-domain-specific-language.md).  
  
 In this example, <CodeContentPlaceHolder>46\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>47\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>48\</CodeContentPlaceHolder> are types that are defined in the DSL, which is derived from the Class Diagram DSL template.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 For more information about how to navigate from object to object in the model, and about how to create objects and links, see [How to Navigate and Update a Model](../vs140/how-to--modify-a-standard-menu-command-in-a-domain-specific-language.md).  
  
### Register the command  
 Repeat in C# the declarations of the GUID and ID values that you made in the Symbols section of CommandSet.vsct:  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 Use the same GUID value as you inserted in **Commands.vsct**.  
  
> [!NOTE]
>  If you change the Symbols section of the VSCT file, you must also change these declarations to match. You should also increment the version number in Package.tt  
  
 Register your menu commands as part of this command set. <CodeContentPlaceHolder>49\</CodeContentPlaceHolder> is called once when the diagram is initialized:  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
## Test the Command  
 Build and run the DSL in an experimental instance of Visual Studio. The command should appear in the shortcut menu in the situations you have specified.  
  
#### To exercise the command  
  
1.  On the **Solution Explorer** toolbar, click **Transform All Templates**.  
  
2.  Press **F5** to rebuild the solution, and start debugging the domain-specific language in the experimental build.  
  
3.  In the experimental build, open a sample diagram.  
  
4.  Right-click various items in the diagram to verify that the command is correctly enabled or disabled, and appropriately shown or hidden, depending on the selected item.  
  
## Troubleshooting  
 **Command does not appear in menu:**  
  
-   The command will appear only in debugging instances of Visual Studio, until you install the DSL package. For more information, see [Deploying a DSL](../vs140/deploying-domain-specific-language-solutions.md).  
  
-   Make sure that your experimental sample has the correct file name extension for this DSL. To check the file name extension, open DslDefinition.dsl in the main instance of Visual Studio. Then in DSL Explorer, right-click the Editor node, and then click Properties. In the Properties window, examine the FileExtension property.  
  
-   Did you [increment the package version number](#version)?  
  
-   Set a breakpoint at the beginning of your OnStatus method. It should break when you right-click over any part of the diagram.  
  
     **OnStatus method is not called**:  
  
    -   Make sure that the GUIDs and IDs in your CommandSet code match those in the Symbols section of Commands.vsct.  
  
    -   In Commands.vsct, make sure that the GUID and ID in every Parent node identify the correct parent Group.  
  
    -   In a Visual Studio command prompt, type devenv /rootsuffix exp /setup. Then restart the debugging instance of Visual Studio.  
  
-   Step through the OnStatus method to verify that command.Visible and command.Enabled are set to true.  
  
 **Wrong menu text appears, or command appears in the wrong place**:  
  
-   Make sure that the combination of GUID and ID is unique to this command.  
  
-   Make sure that you have uninstalled earlier versions of the package.  
  
## See Also  
 [Programming Domain-Specific Languages](../vs140/writing-code-to-customise-a-domain-specific-language.md)   
 [How to Navigate and Update a Model](../vs140/how-to--modify-a-standard-menu-command-in-a-domain-specific-language.md)   
 [Deployment](../vs140/deploying-domain-specific-language-solutions.md)   
 [Sample code: Circuit Diagrams](http://code.msdn.microsoft.com/Visualization-Modeling-SDK-763778e8)