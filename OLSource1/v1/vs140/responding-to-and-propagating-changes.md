---
title: "Responding to and Propagating Changes"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-tfs-dev14"
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: "article"
helpviewer_keywords: 
  - "Domain-Specific Language, events"
ms.assetid: fc2e9ac5-7a84-44ed-9945-94e45f89c227
caps.latest.revision: 28
---
# Responding to and Propagating Changes
When an element is created, deleted or updated, you can write code that propagates the change to other parts of the model, or to external resources such as files, databases, or other components.  
  
## In This Section  
 As a guideline, consider these techniques in the following order:  
  
|Technique|Scenarios|For more information|  
|---------------|---------------|--------------------------|  
|Define a Calculated domain property.|A domain property whose value is calculated from other properties in the model. For example, a price that is the sum of prices of related elements.|[Custom and Calculated Domain Properties](../vs140/calculated-and-custom-storage-properties.md)|  
|Define a Custom Storage domain property.|A domain property stored in other parts of the model or externally. For example, you could parse an expression string into a tree in the model.|[Custom and Calculated Domain Properties](../vs140/calculated-and-custom-storage-properties.md)|  
|Override change handlers such as OnValueChanging and OnDeleting|Keep different elements in sync, and keep external values in sync with the model.<br /><br /> Constrain values to defined ranges.<br /><br /> Called immediately before and after property value and other changes. You can terminate the change by throwing an exception.|[How to Override methods that run when a notification occurs](../vs140/domain-property-value-change-handlers.md)|  
|Rules|You can define rules that are queued for execution just before the end of a transaction in which a change has happened. They are not executed on Undo or Redo. Use them to keep one part of the store in synch with another.|[How to: Create Custom Rules](../vs140/rules-propagate-changes-within-the-model.md)|  
|Store Events|The modeling store provides notifications of events such as adding or deleting an element or link, or changing the value of a property. The event is also executed on Undo and Redo. Use store events to update values that are not in the store.|[How to: Register to be notified on an event](../vs140/event-handlers-propagate-changes-outside-the-model.md)|  
|.NET Events|Shapes have event handlers that respond to mouse clicks and other gestures. You have to register for these events for each object. Registration is typically done in an override of InitializeInstanceResources, and must be done for each element.<br /><br /> These events usually occur outside a transaction.|[How to capture mouse clicks on an icon decorator](../vs140/how-to--intercept-a-click-on-a-shape-or-decorator.md)|  
|Bounds Rules|A bounds rule is used specifically to constrain the bounds of a shape.|[How to Constrain Shapes with BoundsRules](../vs140/boundsrules-constrain-shape-location-and-size.md)|  
|Selection rules|Selection rules specifically constrain what the user can select.|[How to Constrain the selection](../vs140/how-to--access-and-constrain-the-current-selection.md)|  
|OnAssocatedPropertyChanged|Indicate the model elements’ states using features of shapes and connectors such as shadow, arrowheads, color, and line widths and style.|[Updating Shapes and Connectors to Reflect Model Changes](../vs140/updating-shapes-and-connectors-to-reflect-the-model.md)|  
  
## **Comparing Rules and Store Events**  
 Change notifiers, rules, and events are run when changes occur in a model.  
  
 Rules are usually applied at the end transaction in which the change has occurred, and events are applied after changes in a transaction are committed.  
  
 Use store events to synchronize the model with objects outside the Store, and rules to maintain consistency within the Store.  
  
-   **Creating Custom Rules** You create a custom rule as a derived class from an abstract rule. You must also notify the framework about the custom rule. For more information, see [How to: Create Custom Rules](../vs140/rules-propagate-changes-within-the-model.md).  
  
-   **Subscribing to Events** Before you can subscribe to an event, create an event handler and delegate. Then use the <xref:Microsoft.VisualStudio.Modeling.Store.EventManagerDirectory*>property to subscribe to the event. For more information, see [How to: Register to be notified on an event](../vs140/event-handlers-propagate-changes-outside-the-model.md).  
  
-   **Undoing Changes** When you undo a transaction, events are raised, but rules are not applied. If a rule changes a value and you undo that change, the value is reset to the original value during the undo action. When an event is raised, you must manually change the value back to its original value. To learn more about transactons and undo, see [How to: Use Transactions to update a model](../vs140/how-to--use-transactions-to-update-the-model.md).  
  
-   **Passing Event Arguments to Rules and Events** Both events and rules are passed an `EventArgs` parameter that has information about how the model changed.  
  
## See Also  
 [How to: Intercept Click on Icon Decorator](../vs140/how-to--intercept-a-click-on-a-shape-or-decorator.md)   
 [Working with Domain Models Programmatically](../vs140/writing-code-to-customise-a-domain-specific-language.md)