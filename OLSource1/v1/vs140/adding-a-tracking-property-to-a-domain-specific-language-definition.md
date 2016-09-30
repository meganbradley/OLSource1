---
title: "Adding a Tracking Property to a Domain-Specific Language Definition"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-tfs-dev14"
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: "article"
helpviewer_keywords: 
  - "tracking properties [Domain-Specific Language Tools], walkthrough"
  - "Domain-Specific Language Tools, walkthroughs"
  - "walkthroughs [Domain-Specific Language Tools]"
ms.assetid: 4aa47777-de75-4897-a423-a3c4426b4125
caps.latest.revision: 26
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# Adding a Tracking Property to a Domain-Specific Language Definition
This walkthrough shows how to add a tracking property to a domain model.  
  
 A *tracking domain* property is a property that can be updated by the user but which has a default value that is calculated by using the values of other domain properties or elements.  
  
 For example, in the Domain-Specific Language Tools (DSL Tools), the Display Name property of a domain class has a default value that is calculated by using the name of the domain class, but a user can change the value at design time or reset it to the calculated value.  
  
 In this walkthrough, you create a domain-specific language (DSL) that has a Namespace tracking property that has a default value based on the Default Namespace property of the model. For more information about tracking properties, see [Defining Tracking Properties](assetId:///0538b0e4-6221-4e7d-911a-b92cd622f0be).  
  
-   The DSL Tools support tracking property descriptors. However, the DSL designer cannot be used to add a tracking property to a language. Therefore, you must add custom code to define and implement the tracking property.  
  
 A tracking property has two states: tracking, and updated by the user. Tracking properties have the following features:  
  
-   When in the tracking state, the value of the tracking property is calculated, and the value is updated as other properties in the model change.  
  
-   When in the updated by user state, the value of the tracking property retains the value to which the user last set the property.  
  
-   In the **Properties** window, the **Reset** command for the tracking property is only enabled when the property is in the updated by user state. The **Reset** command sets the tracking property state to tracking.  
  
-   In the **Properties** window, when the tracking property is in the tracking state, its value is displayed in a regular font.  
  
-   In the **Properties** window, when the tracking property is in the updated by user state, its value is displayed in a bold font.  
  
## Prerequisites  
 Before you can start this walkthrough, you must first install these components:  
  
|||  
|-|-|  
|[!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)]|[http://go.microsoft.com/fwlink/?LinkID=185579](http://go.microsoft.com/fwlink/?LinkID=185579)|  
|[!INCLUDE[vssdk_current_short](../vs140/includes/vssdk_current_short_md.md)]|[http://go.microsoft.com/fwlink/?LinkID=185580](http://go.microsoft.com/fwlink/?LinkID=185580)|  
|[!INCLUDE[dsl](../vs140/includes/dsl_md.md)]|[http://go.microsoft.com/fwlink/?LinkID=185581](http://go.microsoft.com/fwlink/?LinkID=185581)|  
  
## Creating the DSL Project  
 Create the project for your domain-specific language.  
  
#### To create the project  
  
1.  Create a Domain-Specific Language Designer project. Name it <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>.  
  
2.  In the **Domain-Specific Language Designer Wizard**, set the following options:  
  
    1.  Select the **MinimalLanguage** template.  
  
    2.  Use the default name for the domain-specific language, <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>.  
  
    3.  Set the extension for model files to <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>.  
  
    4.  Use the default template icon for the model files.  
  
    5.  Set the name of the product to <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>.  
  
    6.  Set the name of the company to <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>.  
  
    7.  Use the default value for the root namespace for projects in the solution, <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>.  
  
    8.  Allow the wizard to create a strong name key file for your assemblies.  
  
    9. Review the details of the solution, and then click **Finish** to create the DSL definition project.  
  
## Customizing the Default DSL Definition  
 In this section, you customize the DSL definition to contain the following items:  
  
-   A Namespace tracking property for every element of the model.  
  
-   A Boolean IsNamespaceTracking property for every element of the model. This property will indicate whether the tracking property is in the tracking state or in the updated by user state.  
  
-   A Default Namespace property for the model. This property will be used to calculate the default value of the Namespace tracking property.  
  
-   A CustomElements calculated property for the model. This property will indicate the proportion of elements that have a custom namespace.  
  
#### To add the domain properties  
  
1.  In the DSL designer, right-click the **ExampleModel** domain class, point to **Add**, and then click **DomainProperty**.  
  
    1.  Name the new property <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>.  
  
    2.  In the **Properties** window for the new property, set **Default Value** to <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>, and set **Type** to **String**.  
  
2.  To the **ExampleModel** domain class, add a domain property named <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>.  
  
     In the **Properties** window for the new property, set **Kind** to **Calculated**.  
  
3.  To the **ExampleElement** domain class, add a domain property named <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>.  
  
     In the **Properties** window for the new property, set **Is Browsable** to **False**, and set **Kind** to **CustomStorage**.  
  
4.  To the **ExampleElement** domain class, add a domain property named <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>.  
  
     In the **Properties** window for the new property, set **Is Browsable** to **False**, set **Default Value** to <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>, and set **Type** to **Boolean**.  
  
#### To update the diagram elements and DSL details  
  
1.  In the DSL designer, right-click the **ExampleShape** geometry shape, point to **Add**, and then click **Text Decorator**.  
  
    1.  Name the new text decorator <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>.  
  
    2.  In the **Properties** window for the text decorator, set **Position** to **InnerBottomLeft**.  
  
2.  In the DSL designer, select the line that connects the **ExampleElement** class to the **ExampleShape** shape.  
  
    1.  In the **DSL Details** window, select the **Decorator Maps** tab.  
  
    2.  In the **Decorators** list, select **NamespaceDecorator**, select its check box and then on the **Display property** list, select **Namespace**.  
  
3.  In **DSL Explorer**, expand the **Domain Classes** folder, right-click the **ExampleElement** node, and then click **Add New Domain Type Descriptor**.  
  
    1.  Expand the **ExampleElement** node, and select the **Custom Type Descriptor (Domain Type Descriptor)** node.  
  
    2.  In the **Properties** window for the domain type descriptor, set **Custom Coded** to **True**.  
  
4.  In **DSL Explorer**, select the **Xml Serialization Behavior** node.  
  
    1.  In the **Properties** window, set **Custom Post Load** to **True**.  
  
## Transforming Templates  
 Now that you have defined the domain classes and properties for your DSL, you can verify that the DSL definition can be transformed correctly to regenerate the code for your project.  
  
#### To transform the text templates  
  
1.  On the **Solution Explorer** toolbar, click **Transform All Templates**.  
  
2.  The system regenerates the code for the solution, and saves DslDefinition.dsl. For information about the XML format of definition files, see [The DslDefinition.dsl File](../vs140/the-dsldefinition.dsl-file.md).  
  
## Creating Files for Custom Code  
 When you transform all templates, the system generates the source code that defines your domain-specific language in the Dsl and DslPackage projects. So that you can avoid interfering with the generated text, write your custom code in files that are distinct from the generated code files.  
  
 You must provide code for maintaining the value and the state of your tracking property. To help you distinguish your custom code from the generated code, and to avoid file naming conflicts, put your custom code files in a separate subfolder.  
  
#### To create the code files  
  
1.  In **Solution Explorer**, right-click the **DSL** project, point to **Add**, and then click **New Folder**. Name the new folder <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>.  
  
2.  Right-click the new **CustomCode** folder, point to **Add**, and then click **New Item**.  
  
3.  Select the **Code File** template, set the **Name** to <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>, and then click **OK**.  
  
     The NamespaceTrackingProperty.cs file is created and opened for editing.  
  
4.  In the folder, create the following code files: <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>.  
  
5.  In the **DslPackage** project, also create a <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> folder, and add to it a <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> code file.  
  
## Adding Helper Classes to Support Tracking Properties  
 To the HelperClasses.cs file, add the <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> classes as follows. You will reference these classes later in this walkthrough.  
  
#### To add the helper classes  
  
1.  Add the following code to the HelperClasses.cs file.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Adding Custom Code for the Custom Type Descriptor  
 Implement the <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> method for the type descriptor for the <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> domain class.  
  
> [!NOTE]
>  The code that the DSL Tools generate for the custom type descriptor for <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> calls <CodeContentPlaceHolder>31\</CodeContentPlaceHolder>; however, the DSL Tools do not generate code that implements the method.  
  
 Defining this method creates the tracking property descriptor for the Namespace tracking property. Also, providing attributes for the tracking property enables the **Properties** window to display the property correctly.  
  
#### To modify the type descriptor for the ExampleModel domain class  
  
1.  Add the following code to the TypeDescriptor.cs file.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Adding Custom Code for the Package  
 The generated code defines a type description provider for the ExampleElement domain class; however, you must add code to instruct the DSL to use this type description provider.  
  
#### To update the DSL package to use your custom type descriptor  
  
1.  Add the following code to the Package.cs file.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## Adding Custom Code for the Model  
 Implement the <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> method for the <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> domain class.  
  
> [!NOTE]
>  The code that the DSL Tools generate for <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> calls <CodeContentPlaceHolder>35\</CodeContentPlaceHolder>; however, the DSL Tools do not generate code that implements the method.  
  
 Defining the <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> method provides the logic for the CustomElements calculated property of <CodeContentPlaceHolder>37\</CodeContentPlaceHolder>. This method counts the number of <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> domain classes that have a Namespace tracking property that has a user-updated value, and returns a string that represents this count as a proportion of the total elements in the model.  
  
 In addition, add an <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> method to <CodeContentPlaceHolder>40\</CodeContentPlaceHolder>, and override the <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> method of the <CodeContentPlaceHolder>42\</CodeContentPlaceHolder> nested class of <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> to call <CodeContentPlaceHolder>44\</CodeContentPlaceHolder>.  
  
 Because the DefaultNamespace property is used to calculate the Namespace tracking property, <CodeContentPlaceHolder>45\</CodeContentPlaceHolder> must notify all <CodeContentPlaceHolder>46\</CodeContentPlaceHolder> domain classes that the value of DefaultNamespace has changed.  
  
#### To modify the property handler for the tracked property  
  
1.  Add the following code to the ExampleModel.cs file.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
## Adding Custom Code for the Tracking Property  
 Add a <CodeContentPlaceHolder>47\</CodeContentPlaceHolder> method to the <CodeContentPlaceHolder>48\</CodeContentPlaceHolder> domain class.  
  
 Defining this method provides the logic for the CustomElements calculated property of <CodeContentPlaceHolder>49\</CodeContentPlaceHolder>. This method counts the number of <CodeContentPlaceHolder>50\</CodeContentPlaceHolder> domain classes that have a Namespace tracking property that is in the updated by user state, and returns a string that represents this count as a proportion of the total elements in the model.  
  
 Also, add storage for, and methods to get and set, the Namespace custom storage property of the <CodeContentPlaceHolder>51\</CodeContentPlaceHolder> domain class.  
  
> [!NOTE]
>  The code that the DSL Tools generate for <CodeContentPlaceHolder>52\</CodeContentPlaceHolder> calls the get and set methods; however, the DSL Tools do not generate code that implements the methods.  
  
#### To add the method for the custom type descriptor  
  
1.  Add the following code to the NamespaceTrackingProperty.cs file.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
## Adding Custom Code to Support Serialization  
 Add code to support the custom post-load behavior for XML serialization.  
  
> [!NOTE]
>  The code that the DSL Tools generate calls the <CodeContentPlaceHolder>53\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>54\</CodeContentPlaceHolder> methods; however, the DSL Tools do not generate code that implements these methods.  
  
#### To add code to support the custom post-load behavior  
  
1.  Add the following code to the Serialization.cs file.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
## Testing the Language  
 The next step is to build and run the DSL designer in a new instance of [!INCLUDE[vs_current_short](../vs140/includes/vs_current_short_md.md)] so that you can verify that the tracking property is working correctly.  
  
#### To exercise the language  
  
1.  On the **Build** menu, click **Rebuild Solution**.  
  
2.  On the **Debug** menu, click **Start Debugging**.  
  
     The experimental build of [!INCLUDE[vs_current_short](../vs140/includes/vs_current_short_md.md)] opens the **Debugging** solution, which contains an empty test file.  
  
3.  In **Solution Explorer**, double-click the Test.trackingPropertyDsl file to open it in the designer, and then click the design surface.  
  
     Notice that in the **Properties** window for the diagram, the **Default Namespace** property is **DefaultNamespace**, and the **Custom Elements** property is **0/0**.  
  
4.  Drag an **ExampleElement** element from the **Toolbox** to the diagram surface.  
  
5.  In the **Properties** window for the element, select the **Element Namespace** property, and change the value from **DefaultNamespace** to **OtherNamespace**.  
  
     Notice that the value of **Element Namespace** is now shown in bold.  
  
6.  In the **Properties** window, right-click **Element Namespace**, and then click **Reset**.  
  
     The value of the property is changed to **DefaultNamespace**, and the value is shown in a regular font.  
  
     Right-click **Element Namespace** again. The **Reset** command is now disabled because the property is currently in its tracking state.  
  
7.  Drag another **ExampleElement** from the **Toolbox** to the diagram surface, and change its **Element Namespace** to **OtherNamespace**.  
  
8.  Click the design surface.  
  
     In the **Properties** window for the diagram, the value of **Custom Elements** is now **1/2**.  
  
9. Change **Default Namespace** for the diagram from **DefaultNamespace** to **NewNamespace**.  
  
     The **Namespace** of the first element tracks the **Default Namespace** property, whereas the **Namespace** of the second element retains its user-updated value of **OtherNamespace**.  
  
10. Save the solution, and then close the experimental build.  
  
## Next Steps  
 If you plan to use more than one tracking property, or implement tracking properties in more than one DSL, you can create a text template to generate the common code for supporting each tracking property. For more information about text templates, see [Generating Artifacts By Using Text Templates](../vs140/code-generation-and-t4-text-templates.md).  
  
## See Also  
 \<xref:Microsoft.VisualStudio.Modeling.Design.TrackingPropertyDescriptor*>   
 \<xref:Microsoft.VisualStudio.Modeling.Design.ElementTypeDescriptor*>   
 [Defining Domain Models](../vs140/how-to-define-a-domain-specific-language.md)   
 [Walkthrough: Creating a Domain-Specific Language Solution](../vs140/how-to--create-a-domain-specific-language-solution.md)   
 [Walkthrough: Customizing the Domain-Specific Language Definition](../vs140/walkthrough--customizing-the-domain-specific-language-definition.md)