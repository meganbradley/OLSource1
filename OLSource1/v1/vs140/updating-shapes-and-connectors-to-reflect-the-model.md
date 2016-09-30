---
title: "Updating Shapes and Connectors to Reflect the Model"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-tfs-dev14"
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: "article"
ms.assetid: 51eb2af9-00e7-4725-a87d-62fb4f39f444
caps.latest.revision: 10
---
# Updating Shapes and Connectors to Reflect the Model
In a domain-specific language in [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)], you can make the appearance of a shape reflect the state of the underlying model.  
  
 The code examples in this topic should be added to a <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> file in your <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> project. You will need these statements in each file:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Set Shape Map properties to control the visibility of a decorator  
 You can control the visibility of a decorator without writing program code, by configuring the mapping between the shape and the domain class in the DSL Definition. For more information, see the following topics:  
  
-   [How to control the visibility of a decorator](../vs140/how-to--control-the-visibility-of-a-decorator--redirect.md)  
  
-   [How to Define a Domain-Specific Language](../vs140/how-to-define-a-domain-specific-language.md)  
  
## Expose the color and style of a shape as properties  
 In the DSL Definition, right-click the shape class, point to **Add Exposed**, and then click one of the items such as **Fill Color**.  
  
 The shape now has a domain property that you can set in program code or as a user. For example, to set it in the program code of a command or rule, you could write:  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
  
 If you want to make the property variable only under program control, and not by the user, select the new domain property such as **Fill Color** in the DSL Definition diagram. Then, in the Properties window, set **Is Browsable** to <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> or set **Is UI Readonly** to <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>.  
  
## Define Change Rules to make color, style or location depend on model element properties  
 You can define rules that update the appearance the shape dependent on other parts of the model. For example, you could define a Change Rule on a model element that updates the color of its shape dependent on the properties of the model element. For more information about Change Rules, see [Rules Propagate Changes Within the Model](../vs140/rules-propagate-changes-within-the-model.md).  
  
 You should use rules only to update properties that are maintained within the Store, because rules are not invoked when the Undo command is performed. This does not include some graphical features such as the size and visibility of a shape. To update those features of a shape, see [Updating Non-Store Graphical features](#OnAssociatedProperty).  
  
 The following example assumes that you have exposed <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> as a domain property as described in the previous section.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Use OnChildConfigured to initialize a shape’s properties  
 To set the properties of a shape when it is first created, the override <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> in a partial definition of your diagram class. The diagram class is specified in your DSL Definition, and the generated code is in **Dsl\Generated Code\Diagram.cs**. For example:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 This method can be used both for domain properties and non-store features, such as the size of the shape.  
  
##  \<a name="OnAssociatedProperty">\</a> Use AssociateValueWith() to update other features of a shape  
 For some features of a shape, such as whether it has a shadow, or the arrow style of a connector, there is no built-in method of exposing the feature as a domain property.  Changes to such features are not under the control of the transaction system. Therefore, it is not appropriate to update them using rules, because rules are not invoked when the user performs the Undo command.  
  
 Instead, you can update such features by using \<xref:Microsoft.VisualStudio.Modeling.Diagrams.ShapeElement.OnAssociatedPropertyChanged*>. In the following example, the arrow style of a connector is controlled by a value of a domain property in the relationship that the connector displays:  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> should be called one time for each domain property that you want to register. After it has been called, any changes to the specified property will call <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> in any shapes that present the property’s model element.  
  
 It is not necessary to call <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> for each instance. Although InitializeResources is an instance method, it is invoked only one time for each shape class.