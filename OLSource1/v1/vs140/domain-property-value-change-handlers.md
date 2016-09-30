---
title: "Domain Property Value Change Handlers"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-tfs-dev14"
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: "article"
helpviewer_keywords: 
  - "Domain-Specific Language, overriding event handlers"
ms.assetid: 96d8f392-045e-4bc5-b165-fbaa470a3e16
caps.latest.revision: 28
---
# Domain Property Value Change Handlers
In a [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] domain-specific language, when the value of a domain property changes, the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> methods are invoked in the domain property handler. To respond to the change, you can override these methods.  
  
## Overriding the Property Handler methods  
 Each domain property of your domain-specific language is handled by a class that is nested inside its parent domain class. Its name follows the format *PropertyName*PropertyHandler. You can inspect this property handler class in the file **Dsl\Generated Code\DomainClasses.cs**. In the class, <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> is called immediately before the value changes, and <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> is called immediately after the value changes.  
  
 For example, suppose you have a domain class named <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> that has a string domain property named <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> and an integer property named <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>. To cause <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> always to contain the length of the <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> string, you could write the following code in a separate file in the Dsl project:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 Notice the following points about property handlers:  
  
-   The property handler methods are called both when the user makes changes to a domain property, and when program code assigns a different value to the property.  
  
-   The methods are called only when the value actually changes. The handler is not invoked if program code assigns a value that is equal to the current value.  
  
-   Calculated and custom storage domain properties do not have OnValueChanged and OnValueChanging methods.  
  
-   You cannot use a change handler to modify the new value. If you want to do that, for example to restrict the value to a particular range, define a <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>.  
  
-   You cannot add a change handler to a property that represents a role of a relationship. Instead, define an <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> and a <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> on the relationship class. These rules are triggered when the links are created or changed. For more information, see [Rules](../vs140/rules-propagate-changes-within-the-model.md).  
  
### Changes in and out of the store  
 Property handler methods are called inside the transaction that initiated the change. Therefore, you can make more changes in the store without opening a new transaction. Your changes might result in additional handler calls.  
  
 When a transaction is being undone, redone, or rolled back, you should not make changes in the store,  that is, changes to model elements, relationships, shapes, connectors  diagrams, or their properties.  
  
 Furthermore, you would usually not update values when the model is being loaded from the file.  
  
 Changes to the model should therefore be guarded by a test like this:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 By contrast, if your property handler propagates changes outside the store,  for example, to a file, database, or non-store variables, then you should always make those changes so that the external values are updated when the user invokes undo or redo.  
  
### Canceling a change  
 If you want to prevent a change, you can roll back the current transaction. For example, you might want to ensure that a property remains within a specific range.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Alternative technique: Calculated Properties  
 The previous example shows how OnValueChanged() can be used to propagate values from one domain property to another. Each property has its own stored value.  
  
 Instead, you could consider defining the derived property as a Calculated property. In that case, the property has no storage of its own, and is defining function is evaluated whenever its value is required. For more information, see [Calculated and Custom Domain Properties](../vs140/calculated-and-custom-storage-properties.md).  
  
 Instead of the previous example, you could set the **Kind** field of <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> to be **Calculated** in the DSL Definition. You would provide your own **Get** method for this domain property. The **Get** method would return the current length of the <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> string.  
  
 However, a potential drawback of calculated properties is that the expression is evaluated every time the value is used, which might present a performance problem. Also, there is no OnValueChanging() and OnValueChanged() on a calculated property.  
  
### Alternative technique: Change Rules  
 If you define a ChangeRule, it is executed at the end of a transaction in which a property’s value changes.  For more information, see [Rules](../vs140/rules-propagate-changes-within-the-model.md).  
  
 If several changes are made in one transaction, the ChangeRule executes when they are all complete. By contrast, the OnValue... methods are executed when some of the changes have not been performed. Depending on what you want to achieve, this might make a ChangeRule more appropriate.  
  
 You can also use a ChangeRule to adjust the property’s new value to keep it within a specific range.  
  
> [!WARNING]
>  If a rule makes changes to the store content, other rules and property handlers might be triggered. If a rule changes the property that triggered it, it will be called again. You must make sure that your rule definitions do not result in endless triggering.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
## Example  
  
### Description  
 The following example overrides the property handler of a domain property and notifies the user when a property for the <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> domain class has changed.  
  
### Code  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
## See Also  
 <xref:Microsoft.VisualStudio.Modeling.DomainPropertyValueHandler<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>2.OnValueChanging*>