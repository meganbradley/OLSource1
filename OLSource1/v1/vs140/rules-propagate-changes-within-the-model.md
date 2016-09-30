---
title: "Rules Propagate Changes Within the Model"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-tfs-dev14"
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: "article"
helpviewer_keywords: 
  - "Domain-Specific Language, programming domain models"
  - "Domain-Specific Language, rules"
ms.assetid: 1690a38a-c8f5-4bc6-aab9-015771ec6647
caps.latest.revision: 34
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# Rules Propagate Changes Within the Model
You can create a store rule to propagate a change from one element to another in Visualization and Modeling SDK (VMSDK). When a change occurs to any element in the Store, rules are scheduled to be executed, usually when the outermost transaction is committed. There are different types of rules for different kinds of events, such as adding an element, or deleting it. You can attach rules to specific types of elements, shapes, or diagrams. Many built-in features are defined by rules: for example, rules ensure that a diagram is updated when the model changes. You can customize your domain-specific language by adding your own rules.  
  
 Store rules are particularly useful for propagating changes inside the store – that is, changes to model elements, relationships, shapes or connectors, and their domain properties. Rules do not run when the user invokes the Undo or Redo commands. Instead, the transaction manager makes sure that the store contents are restored to the correct state. If you want to propagate changes to resources outside the store, use Store Events. For more information, see [Store Events](../vs140/event-handlers-propagate-changes-outside-the-model.md).  
  
 For example, suppose that you want to specify that whenever the user (or your code) creates a new element of type ExampleDomainClass, an additional element of another type is created in another part of the model. You could write an AddRule and associate it with ExampleDomainClass. You would write code in the rule to create the additional element.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
> [!NOTE]
>  The code of a rule should change the state only of elements inside the Store; that is, the rule should change only model elements, relationships, shapes, connectors, diagrams, or their properties. If you want to propagate changes to resources outside the store, define Store Events. For more information, see [Store Events](../vs140/event-handlers-propagate-changes-outside-the-model.md)  
  
### To define a rule  
  
1.  Define the rule as a class prefixed with the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> attribute. The attribute associates the rule with one of your domain classes, relationships, or diagram elements. The rule will be applied to every instance of this class, which may be abstract.  
  
2.  Register the rule by adding it to the set returned by <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> in your domain model class.  
  
3.  Derive the rule class from one of the abstract Rule classes, and write the code of the execution method.  
  
 The following sections describe these steps in more detail.  
  
### To define a rule on a domain class  
  
-   In a custom code file, define a class and prefix it with the \<xref:Microsoft.VisualStudio.Modeling.RuleOnAttribute*> attribute:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
-   The subject type in the first parameter can be a domain class, domain relationship, shape, connector, or diagram. Usually, you apply rules to domain classes and relationships.  
  
     The <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> is usually <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>. This ensures that the rule is executed only after all the primary changes of the transaction have been made. The alternatives are Inline, which executes the rule soon after the change; and LocalCommit, which executes the rule at the end of the current transaction (which might not be the outermost). You can also set the priority of a rule to affect its ordering in the queue, but this is an unreliable method of achieving the result you require.  
  
-   You can specify an abstract class as the subject type.  
  
-   The rule applies to all instances of the subject class.  
  
-   The default value for <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> is TimeToFire.TopLevelCommit. This causes the rule to be executed when the outermost transaction is committed. An alternative is TimeToFire.Inline. This causes the rule to be executed soon after the triggering event.  
  
### To register the rule  
  
-   Add your rule class to the list of types returned by <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> in your domain model:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
-   If you are not sure of the name of your domain model class, look inside the file **Dsl\GeneratedCode\DomainModel.cs**  
  
-   Write this code in a custom code file in your DSL project.  
  
### To write the code of the rule  
  
-   Derive the rule class from one of the following base classes:  
  
    |Base class|Trigger|  
    |----------------|-------------|  
    |\<xref:Microsoft.VisualStudio.Modeling.AddRule*>|An element, link, or shape is added.\<br />\<br /> Use this to detect new relationships, in addition to new elements.|  
    |\<xref:Microsoft.VisualStudio.Modeling.ChangeRule*>|A domain property value is changed. The method argument provides the old and new values.\<br />\<br /> For shapes, this rule is triggered when the built-in <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> property changes, if the shape is moved.\<br />\<br /> In many cases, it is more convenient to override <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> in the property handler. These methods are called immediately before and after the change. By contrast, the rule usually runs at the end of the transaction. For more information, see [Handling Property Changes](../vs140/domain-property-value-change-handlers.md). **Note:**  This rule is not triggered when a link is created or deleted. Instead, write an <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> and a <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> for the domain relationship.|  
    |\<xref:Microsoft.VisualStudio.Modeling.DeletingRule*>|Triggered when an element or link is about to be deleted. The property ModelElement.IsDeleting is true until the end of the transaction.|  
    |\<xref:Microsoft.VisualStudio.Modeling.DeleteRule*>|Performed when an element or link has been deleted. The rule is executed after all other rules have been executed, including DeletingRules. ModelElement.IsDeleting is false, and ModelElement.IsDeleted is true. To allow for a subsequent Undo, the element is not actually removed from the memory, but it is removed from Store.ElementDirectory.|  
    |\<xref:Microsoft.VisualStudio.Modeling.MoveRule*>|An element is moved from one store partition to another.\<br />\<br /> (Notice that this is not related to the graphical position of a shape.)|  
    |\<xref:Microsoft.VisualStudio.Modeling.RolePlayerChangeRule*>|This rule applies only to domain relationships. It is triggered if you explicitly assign a model element to either end of a link.|  
    |\<xref:Microsoft.VisualStudio.Modeling.RolePlayerPositionChangeRule*>|Triggered when the ordering of links to or from an element is changed using the MoveBefore or MoveToIndex methods on a link.|  
    |\<xref:Microsoft.VisualStudio.Modeling.TransactionBeginningRule*>|Executed when a transaction is created.|  
    |\<xref:Microsoft.VisualStudio.Modeling.TransactionCommittingRule*>|Executed when the transaction is about to be committed.|  
    |\<xref:Microsoft.VisualStudio.Modeling.TransactionRollingBackRule*>|Executed when the transaction is about to be rolled back.|  
  
-   Each class has a method that you override. Type <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> in your class to discover it. The parameter of this method identifies the element that is being changed.  
  
 Notice the following points about rules:  
  
1.  The set of changes in a transaction might trigger many rules. Usually, the rules are executed when the outermost transaction is committed. They are executed in an unspecified order.  
  
2.  A rule is always executed inside a transaction. Therefore, you do not have to create a new transaction to make changes.  
  
3.  Rules are not executed when a transaction is rolled back, or when the Undo or Redo operations are performed. These operations reset all the content of the Store to its previous state. Therefore, if your rule changes the state of anything outside the Store, it might not keep in synchronism with the Store content. To update state outside the Store, it is better to use Events. For more information, see [Store Events](../vs140/event-handlers-propagate-changes-outside-the-model.md).  
  
4.  Some rules are executed when a model is loaded from file. To determine whether loading or saving is in progress, use <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>.  
  
5.  If the code of your rule creates more rule triggers, they will be added to the end of the firing list, and will be executed before the transaction completes. DeletedRules are executed after all other rules. One rule can run many times in a transaction, one time for each change.  
  
6.  To pass information to and from rules, you can store information in the <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>. This is just a dictionary that is maintained during the transaction. It is disposed when the transaction ends. The event arguments in each rule provide access to it. Remember that rules are not executed in a predictable order.  
  
7.  Use rules after considering other alternatives. For example, if you want to update a property when a value changes, consider using a calculated property. If you want to constrain the size or location of a shape, use a <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>. If you want to respond to a change in a property value, add an <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> handler to the property. For more information, see [Responding to Changes in the Model](../vs140/responding-to-and-propagating-changes.md).  
  
## Example  
 The following example updates a property when a domain relationship is instantiated to link two elements. The rule will be triggered not only when the user creates a link on a diagram, but also if program code creates a link.  
  
 To test this example, create a DSL using the Task Flow solution template, and insert the following code in a file in the Dsl project. Build and run the solution, and open the Sample file in the Debugging project. Draw a Comment Link between a Comment shape and a flow element. The text in the comment changes to report on the most recent element that you have connected it to.  
  
 In practice, you would usually write a DeleteRule for every AddRule.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
## See Also  
 [Events Propagate changes outside the model](../vs140/event-handlers-propagate-changes-outside-the-model.md)   
 [BoundsRules Constrain Shape Location](../vs140/boundsrules-constrain-shape-location-and-size.md)