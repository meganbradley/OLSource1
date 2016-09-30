---
title: "Integrating Models by using Visual Studio Modelbus"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-tfs-dev14"
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: "article"
ms.assetid: 2ff722f3-21d6-44e2-9efd-f6694aee9987
caps.latest.revision: 30
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# Integrating Models by using Visual Studio Modelbus
[!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] ModelBus provides a method for creating links between models and from other tools into models. For example, you could link domain-specific language (DSL) models and UML models. You can create an integrated set of DSLs.  
  
 ModelBus lets you create a unique reference to a model or to a specific element inside a model. This reference can be stored outside the model, for example, in an element in another model. When, on a later occasion, a tool wants to obtain access to the element, the Model Bus infrastructure will load the appropriate model and return the element. If you want, you can display the model to the user. If the file cannot be accessed in its previous location, ModelBus will ask the user to find it. If the user finds the file, ModelBus will fix all the references to that file.  
  
> [!NOTE]
>  In the current [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] implementation of ModelBus, the linked models must be items in the same [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] solution.  
  
 For additional information and sample code, see:  
  
-   [How to add a drag and drop handler](../vs140/how-to--add-a-drag-and-drop-handler.md)  
  
-   [Modeling SDK for Visual Studio](http://www.microsoft.com/download/details.aspx?id=40754)  
  
##  \<a name="provide">\</a> Providing Access to a DSL  
 Before you can create ModelBus references to a model or its elements, you must define a ModelBusAdapter for the DSL. The easiest way to do this is to use the [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] Model Bus Extension, which adds commands to the DSL Designer.  
  
###  \<a name="expose">\</a> To expose a DSL Definition to Model Bus  
  
1.  Download and install the Visual Studio Model Bus extension, unless you have already installed it. For more information, see [Visualization and Modeling SDK](http://go.microsoft.com/fwlink/?LinkID=185579).  
  
2.  Open the DSL definition file. Right-click the design surface and then click **Enable Modelbus**.  
  
3.  In the dialog box, choose **I want to expose this DSL to the ModelBus**. You can choose both options if you want this DSL both to expose its models and to consume references to other DSLs.  
  
4.  Click **OK**. A new project "ModelBusAdapter" is added to the DSL solution.  
  
5.  If you want to access the DSL from a text template, you must modify AdapterManager.tt in the new project. Omit this step if you want to access the DSL from other code such as commands and event handlers. For more information, see [Using ModelBus in a Text Template](../vs140/using-visual-studio-modelbus-in-a-text-template.md).  
  
    1.  Change the base class of AdapterManagerBase to \<xref:Microsoft.VisualStudio.TextTemplating.Modeling.VsTextTemplatingModelingAdapterManager*>.  
  
    2.  Near the end of the file, insert this additional attribute in front of class AdapterManager:  
  
         <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
  
    3.  In the References of ModelBusAdapter project, add **Microsoft.VisualStudio.TextTemplating.Modeling.11.0**.  
  
     If you want to access the DSL both from text templates and from other code, you need two adapters, one modified and one unmodified.  
  
6.  Click **Transform All Templates**.  
  
7.  Rebuild the solution.  
  
 It is now possible for ModelBus to open instances of this DSL.  
  
 The folder <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> contains the assemblies built by the <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> project and the <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> project. To reference this DSL from another DSL, you should import these assemblies.  
  
### Making sure that elements can be referenced  
 [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] ModelBus adapters use the guid of an element to identify it, by default. These identifiers must therefore be persisted in the model file.  
  
##### To ensure that element IDs are persisted  
  
1.  Open DslDefinition.dsl.  
  
2.  In DSL Explorer, expand **Xml Serialization Behavior**, then **Class Data**.  
  
3.  For each class to which you want to create Model Bus references:  
  
     Click the class node, and in the Properties window, make sure that **Serialize Id** is set to <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>.  
  
 Alternatively, if you want to use element names to identify elements instead of guids, you can override parts of the generated adapters. Override the following methods in the adapter class:  
  
-   Override <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> to return the identifier you want to use. This method is called when creating references.  
  
-   Override <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> to locate the correct element from a Model Bus reference.  
  
##  \<a name="editRef">\</a> Accessing a DSL from another DSL  
 You can store model bus references in a domain property in a DSL, and you can write custom code that uses them. You can also let the user create a model bus reference by picking a model file and an element within it.  
  
 To enable a DSL to use references to another DSL, you should first make it a *consumer* of model bus references.  
  
#### To enable a DSL to consume references to an exposed DSL  
  
1.  In the DSL Definition diagram, right-click the main part of the diagram and then click **Enable Modelbus**.  
  
2.  In the dialog box, select **I want to enable this model to consume model bus references**.  
  
3.  In the Dsl project of the consuming DSL, add the following assemblies to the project references. You will find these assemblies (.dll files) in the ModelBusAdapter\bin\\* directory of the exposed DSL.  
  
    -   The exposed DSL assembly, for example **Fabrikam.FamilyTree.Dsl.dll**  
  
    -   The exposed model bus adapter assembly, for example **Fabrikam.FamilyTree.ModelBusAdapter.dll**  
  
4.  Add the following .NET assemblies to the project references of the consuming DSL project.  
  
    1.  **Microsoft.VisualStudio.Modeling.Sdk.Integration.11.0.dll**  
  
    2.  **Microsoft.VisualStudio.Modeling.Sdk.Integration.Shell.11.0.dll**  
  
#### To store a Model Bus Reference in a domain property  
  
1.  In the DSL Definition of the consuming DSL, add a domain property to a domain class and set its name.  
  
2.  In the Properties window, with the domain property selected, set **Type** to <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>.  
  
 At this stage, program code can set the property value, but it is read-only in the Properties window.  
  
 You can allow users to set the property with a specialized ModelBus reference editor. There are two versions of this editor or *picker:* one allows users to choose a model file, and the other allows users to choose a model file and an element within the model.  
  
#### To allow the user to set a Model Bus Reference in a domain property  
  
1.  Right-click the domain property and then click **Edit ModelBusReference specific properties**. A dialog box opens. This is the *Model Bus Picker*.  
  
2.  Select the appropriate **Kind of ModelBusReference**: to a model or to an element inside a model.  
  
3.  In file dialog filter string, enter a string such as <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>. Subsitute the file extension of your exposed DSL.  
  
4.  If you chose to reference an element in a model, you can add a list of types that the user can select, for example Company.FamilyTree.Person.  
  
5.  Click **OK**, and then click **Transform All Templates** in the solution explorer toolbar.  
  
    > [!WARNING]
    >  If you have not selected a valid model or entity, the OK button will have no effect, even though it might appear enabled.  
  
6.  If you specified a list of target types such as Company.FamilyTree.Person, then you must add an assembly reference to your DSL project, referencing the DLL of the target DSL, for example Company.FamilyTree.Dsl.dll  
  
#### To test a Model Bus Reference  
  
1.  Build both the exposed and consuming DSLs.  
  
2.  Run one of the DSLs in experimental mode by pressing F5 or CTRL+F5.  
  
3.  In the Debugging project in the experimental instance of [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)], add files that are instances of each DSL.  
  
    > [!NOTE]
    >  [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] ModelBus can only resolve references to models that are items in the same [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] solution. For example, you cannot create a reference to a model file in another part of your file system.  
  
4.  Create some elements and links in the instance of the exposed DSL, and save it.  
  
5.  Open an instance of the consuming DSL, and select a model element that has a model bus reference property.  
  
6.  In Properties window, double-click the model bus reference property. The picker dialog opens.  
  
7.  Click **Browse** and select the instance of the exposed DSL.  
  
     The picker will also let you choose an item in the model, if you specified the element-specific kind of model bus reference.  
  
## Creating References in Program Code  
 When you want to store a reference to a model or an element inside a model, you create a <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>. There are two kinds of <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>: model references and element references.  
  
 To create a model reference, you need the AdapterManager of the DSL of which the model is an instance, and the filename or [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] project item of the model.  
  
 To create an element reference, you need an adapter for the model file, and the element you want to refer to.  
  
> [!NOTE]
>  With the [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] ModelBus, you can create references only to items in the same [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] solution.  
  
### Import the exposed DSL assemblies  
 In the consuming project, add project references to the DSL and ModelBusAdapter assemblies of the exposed DSL.  
  
 For example, suppose that you want to store ModelBus References in elements of a MusicLibrary DSL. The ModelBus References will refer to elements of the FamilyTree DSL. In the <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> project of the MusicLibrary solution, in the References node, add references to the following assemblies:  
  
-   Fabrikam.FamilyTree.Dsl.dll - the exposed DSL.  
  
-   Fabrikam.FamilyTree.ModelBusAdapters.dll - the ModelBus adapter of the exposed DSL.  
  
-   Microsoft.VisualStudio.Modeling.Sdk.Integration.11.0  
  
-   Microsoft.VisualStudio.Modeling.Sdk.Integration.Shell.11.0  
  
 These assemblies can be found in the <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> project of the exposed DSL, under <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>.  
  
 In the code file where you will create references, you will typically have to import these namespaces:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
### To create a reference to a model  
 To create a model reference, you access the AdapterManager for the exposed DSL, and use it to create a reference to the model. You can specify either a file path, or a <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>.  
  
 From the AdapterManager, you can obtain an Adapter, which provides access to individual elements in the model.  
  
> [!NOTE]
>  You must dispose an Adapter when you have finished with it. The most convenient way to achieve this is with a <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> statement. The following example illustrates this.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 If you want to be able to use <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> later, you can store it in a domain property that has the External Type <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 To allow users to edit this domain property, use <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> as the parameter in the Editor attribute. For more information, see [Allow the User to Edit a Reference](#editRef).  
  
### To create a reference to an element  
 The adapter that you created for the model can be used to create and resolve references.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 If you want to be able to use <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> later, you can store it in a domain property that has the External Type <CodeContentPlaceHolder>32\</CodeContentPlaceHolder>. To allow users to edit it, use <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> as the parameter in the Editor attribute. For more information, see [Allow the User to Edit a Reference](#editRef).  
  
### Resolving references  
 If you have a <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> (MBR) you can obtain the model or the model element to which it refers. If the element is presented on a diagram or other view, you can open the view and select the element.  
  
 You can create an adapter from an MBR. From the adapter, you can obtain the root of the model. You can also resolve MBRs that refer to specific elements within the model.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
##### To resolve ModelBus References in a Text Template  
  
1.  The DSL you want to access must have a ModelBus Adapter that has been configured for access by text templates. For more information, see [To provide access to a DSL](#provide).  
  
2.  Typically, you will be accessing a target DSL using a Model Bus Reference (MBR) stored in a source DSL. Your template therefore includes the directive of the source DSL, plus code to resolve the MBR. For more information about text templates, see [Generating Code from a DSL](../vs140/generating-code-from-a-domain-specific-language.md).  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 For more information and a walkthrough, see [Using ModelBus in a Text Template](../vs140/using-visual-studio-modelbus-in-a-text-template.md)  
  
## Serializing a ModelBusReference  
 If you want to store a <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> (MBR) in the form of a string, you can serialize it:  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 A MBR that is serialized in this manner is independent of context. If you are using the simple file-based Model Bus Adapter, the MBR contains an absolute file path. This is sufficient if the instance model files will never move. However, the model files will typically be items in a [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] project. Your users will expect to be able to move the whole project to different parts of the file system. They will also expect to be able to keep the project under source control and open it on different computers. Path names should therefore be serialized relative to the location of the project that contains the files.  
  
### Serializing Relative to a Specified File Path  
 A <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> contains a <CodeContentPlaceHolder>37\</CodeContentPlaceHolder>, which is a dictionary in which you can store information such as the file path relative to which it should be serialized.  
  
 To serialize relative to a path:  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 To retrieve the reference from the string:  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
### ModelBusReferences created by other Adapters  
 The following information is useful if you want to create your own adapter.  
  
 A <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> (MBR) consists of two parts: the MBR header, which is deserialized by the model bus, and an adapter-specific that is handled by the specific adapter manager. This lets you provide your own adapter serialization format. For example, you could reference a database rather than a file, or you could store additional information in the adapter reference. Your own adapter can place additional information in the <CodeContentPlaceHolder>39\</CodeContentPlaceHolder>.  
  
 When you deserialize an MBR, you must provide a ReferenceContext, which is then stored in the MBR object. When you serialize an MBR, the stored ReferenceContext is used by the adapter to help generate the string. The deserialized string does not contain all the information in the ReferenceContext. For example, in the simple file-based adapter, the ReferenceContext contains a root file path, which is not stored in the serialized MBR string.  
  
 The MBR is deserialized in two stages:  
  
-   <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> is the standard serializer that deals with the MBR header. It uses the standard DSL <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> property bag, which is stored in the <CodeContentPlaceHolder>42\</CodeContentPlaceHolder> using the key <CodeContentPlaceHolder>43\</CodeContentPlaceHolder>. In particular, the <CodeContentPlaceHolder>44\</CodeContentPlaceHolder> should contain an instance of <CodeContentPlaceHolder>45\</CodeContentPlaceHolder>.  
  
-   Your ModelBus Adapter deals with the adapter-specific part of the MBR. It can use additional information stored in the ReferenceContext of the MBR. The simple file-based adapter keeps root file paths using the keys <CodeContentPlaceHolder>46\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>47\</CodeContentPlaceHolder>.  
  
     An adapter reference in a model file is deserialized only when it is used.  
  
## To Create a Model  
  
### Creating, opening and editing a model  
 The following fragment is taken from the State Machine sample on the VMSDK Web site. It illustrates the use of ModelBusReferences to create and open a model, and to obtain the diagram associated with the model.  
  
 In this sample, the name of the target DSL is StateMachine. Several names are derived from it, such as the name of the model class and the name of the ModelBusAdapter.  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
## Validating references  
 The BrokenReferenceDetector tests all the domain properties in a Store that can hold ModelBusReferences. It calls the action you that provide where any action is found. This is particularly useful for validation methods. The following validation method tests the store on an attempt to save the model, and reports broken references in the errors window:  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
## Actions performed by the ModelBus Extension  
 The following information is not essential, but might be useful if you make extensive use of ModelBus.  
  
 The ModelBus Extension makes the following changes in your DSL solution.  
  
 When you right-click the DSL Definition diagram, click **Enable Modelbus**, and then select **Enable this DSL to Consume the ModelBus**:  
  
-   In the DSL project, a reference is added to **Microsoft.VisualStudio.Modeling.Sdk.Integration.11.0.dll**  
  
-   In the DSL Definition, an External Type reference is added: <CodeContentPlaceHolder>48\</CodeContentPlaceHolder>.  
  
     You can see the reference in **DSL Explorer**, under **Domain Types**. To add external type references manually, right-click the root node.  
  
-   A new template file is added, **Dsl\GeneratedCode\ModelBusReferencesSerialization.tt**.  
  
 When you set the type of a domain property to ModelBusReference, and then right-click the property and click **Enable ModelBusReference specific properties**:  
  
-   Several CLR attributes are added to the domain property. You can see them in the Custom Attributes field in the Properties window. In **Dsl\GeneratedCode\DomainClasses.cs**, you can see the attributes on the property declaration:  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
 When you right click the DSL Definition Diagram, click **Enable ModelBus**, and select **Expose this DSL to the ModelBus**:  
  
-   A new project <CodeContentPlaceHolder>49\</CodeContentPlaceHolder> is added to the solution.  
  
-   A reference to <CodeContentPlaceHolder>50\</CodeContentPlaceHolder> is added to the <CodeContentPlaceHolder>51\</CodeContentPlaceHolder> project. <CodeContentPlaceHolder>52\</CodeContentPlaceHolder> has a reference to the <CodeContentPlaceHolder>53\</CodeContentPlaceHolder> project.  
  
-   In **DslPackage\source.extention.tt**, <CodeContentPlaceHolder>54\</CodeContentPlaceHolder> is added as a MEF Component.  
  
## See Also  
 [How to read a Model in Program Code](../vs140/how-to--open-a-model-from-file-in-program-code.md)   
 [UML and Modelbus](../vs140/integrate-uml-models-with-other-models-and-tools.md)   
 [How to add a drag and drop handler](../vs140/how-to--add-a-drag-and-drop-handler.md)   
 [Using ModelBus in a Text Template](../vs140/using-visual-studio-modelbus-in-a-text-template.md)