---
title: "Extending the My Namespace in Visual Basic"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-visual-basic"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "vb.AddingMyExtensions"
dev_langs: 
  - "VB"
helpviewer_keywords: 
  - "My namespace, customizing"
  - "My namespace"
  - "My namespace, extending"
ms.assetid: 808e8617-b01c-4135-8b21-babe87389e8e
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Extending the My Namespace in Visual Basic
The <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> namespace in Visual Basic exposes properties and methods that enable you to easily take advantage of the power of the .NET Framework. The <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> namespace simplifies common programming problems, often reducing a difficult task to a single line of code. Additionally, the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> namespace is fully extensible so that you can customize the behavior of <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> and add new services to its hierarchy to adapt to specific application needs. This topic discusses both how to customize existing members of the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> namespace and how to add your own custom classes to the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> namespace.  
  
 **Topic Contents**  
  
-   [Customizing Existing My Namespace Members](#customizing)  
  
-   [Adding Members to My Objects](#addingtoobjects)  
  
-   [Adding Custom Objects to the My Namespace](#addingcustom)  
  
-   [Adding Members to the My Namespace](#addingtonamespace)  
  
-   [Adding Events to Custom My Objects](#addingevents)  
  
-   [Design Guidelines](#design)  
  
-   [Designing Class Libraries for My](#designing)  
  
-   [Packaging and Deploying Extensions](#packaging)  
  
##  \<a name="customizing">\</a> Customizing Existing My Namespace Members  
 The <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> namespace in Visual Basic exposes frequently used information about your application, your computer, and more. For a complete list of the objects in the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> namespace, see [My Reference](../vs140/my-reference--visual-basic-.md). You may have to customize existing members of the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> namespace so that they better match the needs of your application. Any property of an object in the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> namespace that is not read-only can be set to a custom value.  
  
 For example, assume that you frequently use the <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> object to access the current security context for the user running your application. However, your company uses a custom user object to expose additional information and capabilities for users within the company. In this scenario, you can replace the default value of the <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> property with an instance of your own custom principal object, as shown in the following example.  
  
 [!code[VbVbcnExtendingMy#1](../vs140/codesnippet/VisualBasic/extending-the-my-namespace-in-visual-basic_1.vb)]  
  
 Setting the <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> property on the <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> object changes the identity under which the application runs. The <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> object, in turn, returns information about the newly specified user.  
  
##  \<a name="addingtoobjects">\</a> Adding Members to My Objects  
 The types returned from <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> are defined as <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> classes. Therefore, you can extend the <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> objects by creating a <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> class named <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>. The class cannot be a <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> class. If you specify the class as part of the <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> namespace, you can add properties and methods that will be included with the <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> objects.  
  
 For example, the following example adds a property named <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> to the <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> object.  
  
 [!code[VbVbcnExtendingMy#2](../vs140/codesnippet/VisualBasic/extending-the-my-namespace-in-visual-basic_2.vb)]  
  
##  \<a name="addingcustom">\</a> Adding Custom Objects to the My Namespace  
 Although the <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> namespace provides solutions for many common programming tasks, you may encounter tasks that the <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> namespace does not address. For example, your application might access custom directory services for user data, or your application might use assemblies that are not installed by default with Visual Basic. You can extend the <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> namespace to include custom solutions to common tasks that are specific to your environment. The <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> namespace can easily be extended to add new members to meet growing application needs. Additionally, you can deploy your <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> namespace extensions to other developers as a Visual Basic template.  
  
###  \<a name="addingtonamespace">\</a> Adding Members to the My Namespace  
 Because <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> is a namespace like any other namespace, you can add top-level properties to it by just adding a module and specifying a <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> of <CodeContentPlaceHolder>36\</CodeContentPlaceHolder>. Annotate the module with the <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> attribute as shown in the following example. The <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> attribute ensures that IntelliSense will not display the module name when it displays the members of the <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> namespace.  
  
 [!code[VbVbcnExtendingMy#3](../vs140/codesnippet/VisualBasic/extending-the-my-namespace-in-visual-basic_3.vb)]  
  
 To add members to the <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> namespace, add properties as needed to the module. For each property added to the <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> namespace, add a private field of type <CodeContentPlaceHolder>42\</CodeContentPlaceHolder>, where the type is the type returned by your custom property. This field is used to create thread-safe object instances to be returned by the property by calling the <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> method. As a result, each thread that is accessing the extended property receives its own instance of the returned type. The following example adds a property named <CodeContentPlaceHolder>44\</CodeContentPlaceHolder> that is of type <CodeContentPlaceHolder>45\</CodeContentPlaceHolder> to the <CodeContentPlaceHolder>46\</CodeContentPlaceHolder> namespace:  
  
 [!code[VbVbcnExtendingMy#4](../vs140/codesnippet/VisualBasic/extending-the-my-namespace-in-visual-basic_4.vb)]  
  
##  \<a name="addingevents">\</a> Adding Events to Custom My Objects  
 You can use the <CodeContentPlaceHolder>47\</CodeContentPlaceHolder> object to expose events for your custom <CodeContentPlaceHolder>48\</CodeContentPlaceHolder> objects by extending the <CodeContentPlaceHolder>49\</CodeContentPlaceHolder> partial class in the <CodeContentPlaceHolder>50\</CodeContentPlaceHolder> namespace. For Windows-based projects, you can double-click the **My Project** node in for your project in **Solution Explorer**. In the Visual Basic **Project Designer**, click the <CodeContentPlaceHolder>51\</CodeContentPlaceHolder> tab and then click the <CodeContentPlaceHolder>52\</CodeContentPlaceHolder> button. A new file that is named ApplicationEvents.vb will be created. It contains the following code for extending the <CodeContentPlaceHolder>53\</CodeContentPlaceHolder> class.  
  
 [!code[VbVbcnExtendingMy#5](../vs140/codesnippet/VisualBasic/extending-the-my-namespace-in-visual-basic_5.vb)]  
  
 You can add event handlers for your custom <CodeContentPlaceHolder>54\</CodeContentPlaceHolder> objects by adding custom event handlers to the <CodeContentPlaceHolder>55\</CodeContentPlaceHolder> class. Custom events enable you to add code that will execute when an event handler is added, removed, or the event is raised. Note that the <CodeContentPlaceHolder>56\</CodeContentPlaceHolder> code for a custom event runs only if code is added by a user to handle the event. For example, consider that the <CodeContentPlaceHolder>57\</CodeContentPlaceHolder> object from the previous section has a <CodeContentPlaceHolder>58\</CodeContentPlaceHolder> event that you want to add a custom event handler for. The following code example shows a custom event handler named <CodeContentPlaceHolder>59\</CodeContentPlaceHolder> that will be invoked when the <CodeContentPlaceHolder>60\</CodeContentPlaceHolder> event occurs. When code is added to handle the new <CodeContentPlaceHolder>61\</CodeContentPlaceHolder> event, the <CodeContentPlaceHolder>62\</CodeContentPlaceHolder> part of this custom event code is executed. The <CodeContentPlaceHolder>63\</CodeContentPlaceHolder> method is included in the code example to show an example of an event handler that handles the <CodeContentPlaceHolder>64\</CodeContentPlaceHolder> event. Note that the <CodeContentPlaceHolder>65\</CodeContentPlaceHolder> event will be available when you select the **My Application Events** option in the left drop-down list above the Code Editor when you are editing the ApplicationEvents.vb file.  
  
 [!code[VbVbcnExtendingMy#6](../vs140/codesnippet/VisualBasic/extending-the-my-namespace-in-visual-basic_6.vb)]  
  
##  \<a name="design">\</a> Design Guidelines  
 When you develop extensions to the <CodeContentPlaceHolder>66\</CodeContentPlaceHolder> namespace, use the following guidelines to help minimize the maintenance costs of your extension components.  
  
-   **Include only the extension logic.** The logic included in the <CodeContentPlaceHolder>67\</CodeContentPlaceHolder> namespace extension should include only the code that is needed to expose the required functionality in the <CodeContentPlaceHolder>68\</CodeContentPlaceHolder> namespace. Because your extension will reside in user projects as source code, updating the extension component incurs a high maintenance cost and should be avoided if possible.  
  
-   **Minimize project assumptions.** When you create your extensions of the <CodeContentPlaceHolder>69\</CodeContentPlaceHolder> namespace, do not assume a set of references, project-level imports, or specific compiler settings (for example, <CodeContentPlaceHolder>70\</CodeContentPlaceHolder> off). Instead, minimize dependencies and fully qualify all type references by using the <CodeContentPlaceHolder>71\</CodeContentPlaceHolder> keyword. Also, ensure that the extension compiles with <CodeContentPlaceHolder>72\</CodeContentPlaceHolder> on to minimize errors in the extension.  
  
-   **Isolate the extension code.** Placing the code in a single file makes your extension easily deployable as a Visual Studio item template. For more information, see "Packaging and Deploying Extensions" later in this topic. Placing all the <CodeContentPlaceHolder>73\</CodeContentPlaceHolder> namespace extension code in a single file or a separate folder in a project will also help users locate the <CodeContentPlaceHolder>74\</CodeContentPlaceHolder> namespace extension.  
  
##  \<a name="designing">\</a> Designing Class Libraries for My  
 As is the case with most object models, some design patterns work well in the <CodeContentPlaceHolder>75\</CodeContentPlaceHolder> namespace and others do not. When designing an extension to the <CodeContentPlaceHolder>76\</CodeContentPlaceHolder> namespace, consider the following principles:  
  
-   **Stateless methods.** Methods in the <CodeContentPlaceHolder>77\</CodeContentPlaceHolder> namespace should provide a complete solution to a specific task. Ensure that the parameter values that are passed to the method provide all the input required to complete the particular task. Avoid creating methods that rely on prior state, such as open connections to resources.  
  
-   **Global instances.** The only state that is maintained in the <CodeContentPlaceHolder>78\</CodeContentPlaceHolder> namespace is global to the project. For example, <CodeContentPlaceHolder>79\</CodeContentPlaceHolder> encapsulates state that is shared throughout the application.  
  
-   **Simple parameter types.** Keep things simple by avoiding complex parameter types. Instead, create methods that either take no parameter input or that take simple input types such as strings, primitive types, and so on.  
  
-   **Factory methods.** Some types are necessarily difficult to instantiate. Providing factory methods as extensions to the <CodeContentPlaceHolder>80\</CodeContentPlaceHolder> namespace enables you to more easily discover and consume types that fall into this category. An example of a factory method that works well is <CodeContentPlaceHolder>81\</CodeContentPlaceHolder>. There are several stream types available in the .NET Framework. By specifying text files specifically, the <CodeContentPlaceHolder>82\</CodeContentPlaceHolder> helps the user understand which stream to use.  
  
 These guidelines do not preclude general design principles for class libraries. Rather, they are recommendations that are optimized for developers who are using Visual Basic and the <CodeContentPlaceHolder>83\</CodeContentPlaceHolder> namespace. For general design principles for creating class libraries, see [Design Guidelines for Developing Class Libraries](assetId:///5fbcaf4f-ea2a-4d20-b0d6-e61dee202b4b).  
  
##  \<a name="packaging">\</a> Packaging and Deploying Extensions  
 You can include <CodeContentPlaceHolder>84\</CodeContentPlaceHolder> namespace extensions in a Visual Studio project template, or you can package your extensions and deploy them as a Visual Studio item template. When you package your <CodeContentPlaceHolder>85\</CodeContentPlaceHolder> namespace extensions as a Visual Studio item template, you can take advantage of additional capabilities provided by Visual Basic. These capabilities enable you to include an extension when a project references a particular assembly, or enable users to explicitly add your <CodeContentPlaceHolder>86\</CodeContentPlaceHolder> namespace extension by using the **My Extensions** page of the Visual Basic Project Designer.  
  
 For details about how to deploy <CodeContentPlaceHolder>87\</CodeContentPlaceHolder> namespace extensions, see [How to: Package and Deploy Custom My Extensions](../vs140/packaging-and-deploying-custom-my-extensions--visual-basic-.md).  
  
## See Also  
 [How to: Package and Deploy Custom My Extensions](../vs140/packaging-and-deploying-custom-my-extensions--visual-basic-.md)   
 [Extending the Visual Basic Application Model](../vs140/extending-the-visual-basic-application-model.md)   
 [Customizing Which Objects are Available in My](../vs140/customizing-which-objects-are-available-in-my--visual-basic-.md)   
 [My Extensions Page, Project Designer (Visual Basic)](../vs140/my-extensions-page--project-designer--visual-basic-.md)   
 [Application Page, Project Designer (Visual Basic)](../vs140/application-page--project-designer--visual-basic-.md)   
 [Partial (Visual Basic)](../vs140/partial--visual-basic-.md)