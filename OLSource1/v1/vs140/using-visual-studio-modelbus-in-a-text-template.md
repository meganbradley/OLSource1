---
title: "Using Visual Studio ModelBus in a Text Template"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-tfs-dev14"
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: "article"
ms.assetid: 5ed3e5c2-f60f-43c7-8ef4-754f511339c5
caps.latest.revision: 17
---
# Using Visual Studio ModelBus in a Text Template
If you write text templates that read a model that contains [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] ModelBus references, you might want to resolve the references to access the target models. In that case, you have to adapt the text templates and the referenced domain-specific languages (DSLs):  
  
-   The DSL that is the target of the references must have a ModelBus Adapter that is configured for access from text templates. If you also access the DSL from other code, the reconfigured adapter is required in addition to the standard ModelBus Adapter.  
  
     The adapter manager must inherit from \<xref:Microsoft.VisualStudio.TextTemplating.Modeling.VsTextTemplatingModelingAdapterManager*> and must have the attribute <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>.  
  
-   The template must inherit from \<xref:Microsoft.VisualStudio.TextTemplating.Modeling.ModelBusEnabledTextTransformation*>.  
  
> [!NOTE]
>  If you want to read DSL models that do not contain ModelBus references, you can use the directive processors that are generated in your DSL projects. For more information, see [Accessing Models from Text Templates](../vs140/accessing-models-from-text-templates.md).  
  
 For more information about text templates, see [Code Generation in a Visual Studio project](../vs140/design-time-code-generation-by-using-t4-text-templates.md).  
  
## Creating a Model Bus Adapter for Access from Text Templates  
 To resolve a ModelBus reference in a text template, the target DSL must have a compatible adapter. Text templates execute in a separate AppDomain from the [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] document editors, and therefore the adapter has to load the model instead of accessing it through DTE.  
  
#### To create a ModelBus Adapter that is compatible with text templates  
  
1.  If the target DSL solution does not have a **ModelBusAdapter** project, create one by using the Modelbus Extension wizard:  
  
    1.  Download and install the [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] ModelBus Extension, if you have not already done this. For more information, see [Visualization and Modeling SDK](http://go.microsoft.com/fwlink/?LinkID=185579).  
  
    2.  Open the DSL definition file. Right-click the design surface and then click **Enable Modelbus**.  
  
    3.  In the dialog box, select **I want to expose this DSL to the ModelBus**. You can select both options if you want this DSL both to expose its models and to consume references to other DSLs.  
  
    4.  Click **OK**. A new project "ModelBusAdapter" is added to the DSL solution.  
  
    5.  Click **Transform All Templates**.  
  
    6.  Rebuild the solution.  
  
2.  If you want to access the DSL both from a text template and from other code, such as command, duplicate the **ModelBusAdapter** project:  
  
    1.  In Windows Explorer, copy and paste the folder that contains **ModelBusAdapter.csproj**.  
  
    2.  Rename the project file (for example, to **T4ModelBusAdapter.csproj**).  
  
    3.  In **Solution Explorer**, right-click the solution node, point to **Add**, and then click **Existing Project**. Locate the new adapter project, **T4ModelBusAdapter.csproj**.  
  
    4.  In each <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> file of the new project, change the namespace.  
  
    5.  Right-click the new project in Solution Explorer and then click Properties. In the properties editor, change the names of the generated assembly and the default namespace.  
  
    6.  In the DslPackage project, add a reference to the new adapter project so that it has references to both adapters.  
  
    7.  In DslPackage\source.extension.tt, add a line that references your new adapter project.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
    8.  **Transform All Templates** and rebuild the solution. No build errors should occur.  
  
3.  In the new adapter project, add references to the following assemblies:  
  
    -   Microsoft.VisualStudio.TextTemplating.11.0  
  
         Microsoft.VisualStudio.TextTemplating.Modeling.11.0  
  
4.  In AdapterManager.tt:  
  
    -   Change the declaration of AdapterManagerBase so that it inherits from \<xref:Microsoft.VisualStudio.TextTemplating.Modeling.VsTextTemplatingModelingAdapterManager*>.  
  
         <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
  
         <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
  
    -   Near the end of the file, replace the HostSpecific attribute before the AdapterManager class. Remove the following line:  
  
         <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
  
         Insert the following line:  
  
         <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
  
         This attribute filters the set of adapters that is available when a modelbus consumer searches for an adapter.  
  
5.  **Transform All Templates** and rebuild the solution. No build errors should occur.  
  
## Writing a Text Template That Can Resolve ModelBus References  
 Typically, you begin with a template that reads and generates files from a "source" DSL. This template uses the directive that is generated in the source DSL project to read source model files in the manner that is described in [Accessing Models From Text Templates](../vs140/accessing-models-from-text-templates.md). However, the source DSL contains ModelBus References to a "target" DSL. You therefore want to enable the template code to resolve the references and access the target DSL. You therefore must adapt the template by following these steps:  
  
-   Change the base class of the template to \<xref:Microsoft.VisualStudio.TextTemplating.Modeling.ModelBusEnabledTextTransformation*>.  
  
-   Include <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> in the template directive.  
  
-   Add assembly references to the target DSL and its adapter, and to enable ModelBus.  
  
-   You do not need the directive that is generated as part of the target DSL.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 When this text template is executed, the <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> directive loads the file <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>. The template can access the elements of that model, starting from <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>. The code can use the domain classes and properties of that DSL.  
  
 In addition, the template can resolve ModelBus References. Where the references point to the Target model, the assembly directives let the code use the domain classes and properties of that model’s DSL.  
  
-   If you do not use a directive that is generated by a DSL project, you should also include the following.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
-   Use <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> to obtain access to the ModelBus.  
  
## Walkthrough: Testing a Text Template That Uses ModelBus  
 In this walkthrough, you follow these steps:  
  
1.  Construct two DSLs. One DSL, the *Consumer*, has a <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> property that can refer to the other DSL, the *Provider*.  
  
2.  Create two ModelBus Adapters in the Provider: one for access by text templates, the other for ordinary code.  
  
3.  Create instance models of the DSLs in a single experimental project.  
  
4.  Set a domain property in one model to point to the other model.  
  
5.  Write a double-click handler that opens the model that is pointed to.  
  
6.  Write a text template that can load the first model, follow the reference to the other model, and read the other model.  
  
#### Construct a DSL that is accessible to ModelBus  
  
1.  Create a new DSL solution. For this example, select the Task Flow solution template. Set the language name to <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> and the file name extension to ".provide".  
  
2.  In the DSL Definition diagram, right-click a blank part of the diagram that is not near the top, and then click **Enable Modelbus**.  
  
    -   If you do not see **Enable Modelbus**, you must download and install the VMSDK ModelBus extension. Find it on the VMSDK site: [Visualization and Modeling SDK](http://go.microsoft.com/fwlink/?LinkID=185579).  
  
3.  In the **Enable Modelbus** dialog box, select **Expose this DSL to the ModelBus**, and then click **OK**.  
  
     A new project, <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>, is added to the solution.  
  
 You now have a DSL that can be accessed by text templates through ModelBus. References to it can be resolved in the code of commands, event handlers, or rules, all of which operate in the AppDomain of the model file editor. However, text templates run in a separate AppDomain and cannot access a model when it is being edited. If you want to access ModelBus references to this DSL from a text template, you must have a separate ModelBusAdapter.  
  
#### To create a ModelBus Adapter that is configured for Text Templates  
  
1.  In Windows Explorer, copy and paste the folder that contains ModelBusAdapter.csproj.  
  
     Name the folder T4ModelBusAdapter.  
  
     Rename the project file T4ModelBusAdapter.csproj.  
  
2.  In Solution Explorer, add T4ModelBusAdapter to the MBProvider solution. Right-click the solution node, point to **Add**, and then click **Existing Project**.  
  
3.  Right-click the T4ModelBusAdapter project node and then click Properties. In the project properties window, change the **Assembly Name** and **Default Namespace** to <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>.  
  
4.  In each *.tt file in T4ModelBusAdapter, insert "T4" into the last part of the namespace, so that the line resembles the following.  
  
     <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>  
  
5.  In the <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> project, add a project reference to <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>.  
  
6.  In DslPackage\source.extension.tt, add the following line under <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>.  
  
     <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>  
  
7.  In the <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> project, add a reference to: **Microsoft.VisualStudio.TextTemplating.Modeling.11.0**  
  
8.  Open T4ModelBusAdapter\AdapterManager.tt:  
  
    1.  Change the base class of AdapterManagerBase to \<xref:Microsoft.VisualStudio.TextTemplating.Modeling.VsTextTemplatingModelingAdapterManager*>. This part of the file now resembles the following.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
    2.  Near the end of the file, insert the following additional attribute in front of class AdapterManager.  
  
         <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>  
  
         The result resembles the following.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
9. Click **Transform All Templates** in the title bar of Solution Explorer.  
  
10. Rebuild the solution. Click F5.  
  
11. Verify that the DSL is working by pressing  F5. In the experimental project, open <CodeContentPlaceHolder>30\</CodeContentPlaceHolder>. Close the experimental instance of [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)].  
  
 ModelBus References to this DSL can now be resolved in text templates and also in ordinary code.  
  
#### Construct a DSL with a ModelBus Reference domain property  
  
1.  Create a new DSL by using the Minimal Language solution template. Name the language MBConsumer and set the file name extension to ".consume".  
  
2.  In the DSL project, add a reference to the MBProvider DSL assembly. Right-click  <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> and then click **Add Reference**. In the **Browse** tab, locate <CodeContentPlaceHolder>32\</CodeContentPlaceHolder>  
  
     This enables you to create code that uses the other DSL. If you want to create references to several DSLs, add them also.  
  
3.  In the DSL Definition diagram, right-click the diagram and then click **Enable ModelBus**. In the dialog box, select **Enable this DSL to Consume the ModelBus**.  
  
4.  In the class <CodeContentPlaceHolder>33\</CodeContentPlaceHolder>, add a new domain property <CodeContentPlaceHolder>34\</CodeContentPlaceHolder>, and in the Properties window, set its type to <CodeContentPlaceHolder>35\</CodeContentPlaceHolder>.  
  
5.  Right-click the domain property on the diagram and then click **Edit ModelBusReference specific properties**. In the dialog box, select **a model element**.  
  
     Set the file dialog filter to the following.  
  
     <CodeContentPlaceHolder>36\</CodeContentPlaceHolder>  
  
     The substring after "&#124;" is a filter for the file selection dialog box. You could set it to allow any files by using *.\*  
  
     In the **Model Element type** list, enter the names of one ore more domain classes in the provider DSL (for example, Company.MBProvider.Task). They can be abstract classes. If you leave the list blank, the user can set the reference to any element.  
  
6.  Close the dialog and **Transform All Templates**.  
  
 You have created a DSL that can contain references to elements in another DSL.  
  
#### Create a ModelBus reference to another file in the solution  
  
1.  In the MBConsumer solution, press CTRL+F5. An experimental instance of [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] opens in the **MBConsumer\Debugging** project.  
  
2.  Add a copy of Sample.provide to the **MBConsumer\Debugging** project. This is necessary because a ModelBus reference must refer to a file in the same solution.  
  
    1.  Right-click the Debugging project, point to **Add**, and then click **Existing Item**.  
  
    2.  In the **Add Item** dialog, set the filter to **All Files (\*.\*)**.  
  
    3.  Navigate to <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> and then click **Add**.  
  
3.  Open <CodeContentPlaceHolder>38\</CodeContentPlaceHolder>.  
  
4.  Click one example shape, and in the Properties window, click **[...]** in the MBR property. In the dialog box, click **Browse** and select <CodeContentPlaceHolder>39\</CodeContentPlaceHolder>. In the elements window, expand the type Task and select one of the elements.  
  
5.  Save the file.  
  
     (Do not yet close the experimental instance of [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)].)  
  
 You have created a model that contains a ModelBus reference to an element in another model.  
  
#### Resolve a ModelBus Reference in a text template  
  
1.  In the experimental instance of [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)], open a sample text template file. Set its content as follows.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
     Notice the following points:  
  
    1.  The <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> attributes of the <CodeContentPlaceHolder>42\</CodeContentPlaceHolder> directive must be set.  
  
    2.  The consumer model is accessed in the usual manner through the directive processor that was generated in that DSL.  
  
    3.  The assembly and import directives must be able to access ModelBus and the types of the provider DSL.  
  
    4.  If you know that many MBRs are linked to the same model, it is better to call CreateAdapter only one time.  
  
2.  Save the template. Verify that the resulting text file resembles the following.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
#### Resolve a ModelBus reference in a gesture handler  
  
1.  Close the experimental instance of [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)], if it is running.  
  
2.  Add a file that is named MBConsumer\Dsl\Custom.cs and set its content to the following.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
3.  Press CTRL+F5.  
  
4.  In the experimental instance of [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)], open <CodeContentPlaceHolder>43\</CodeContentPlaceHolder>.  
  
5.  Double-click one shape.  
  
     If you have set the MBR on that element, the referenced model opens and the referenced element is selected.  
  
## See Also  
 [Integrating Models by using Visual Studio ModelBus](../vs140/integrating-models-by-using-visual-studio-modelbus.md)   
 [Code Generation and Text Templates](../vs140/code-generation-and-t4-text-templates.md)