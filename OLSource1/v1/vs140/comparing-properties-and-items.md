---
title: "Comparing Properties and Items"
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
  - "msbuild, msbuild properties"
ms.assetid: b9da45ae-d6a6-4399-8628-397deed31486
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Comparing Properties and Items
MSBuild properties and items are both used to pass information to tasks, evaluate conditions, and store values that can be referenced throughout the project file.  
  
-   Properties are name-value pairs. For more information, see [MSBuild Properties](../vs140/msbuild-properties.md).  
  
-   Items are objects that typically represent files. Item objects can have associated metadata collections. Metadata are name-value pairs. For more information, see [MSBuild Items](../vs140/msbuild-items.md).  
  
## Scalars and Vectors  
 Because MSBuild properties are name-value pairs that have just one string value, they are often described as *scalar*. Because MSBuild item types are lists of items, they are often described as *vector*. However, in practice, properties can represent multiple values, and item types can have zero or one items.  
  
### Target Dependency Injection  
 To see how properties can represent multiple values, consider a common usage pattern for adding a target to a list of targets to be built. This list is typically represented by a property value, with the target names separated by semicolons.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 The <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> property is typically used as the argument of a target <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> attribute, effectively converting it to an item list. This property can be overridden to add a target or to change the target execution order. For example,  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 adds the CustomBuild target to the target list, giving <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> the value <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>.  
  
 Starting with MSBuild 4.0, target dependency injection is deprecated. Use the <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> attributes instead. For more information, see [Target Build Order](../vs140/target-build-order.md).  
  
### Conversions between Strings and Item Lists  
 MSBuild performs conversions to and from item types and string values as needed. To see how an item list can become a string value, consider what happens when an item type is used as the value of an MSBuild property:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The item type OutputDir has an <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> attribute with the value "KeyFiles\\;Certificates\\". MSBuild parses this string into two items: KeyFiles\ and Certificates\\. When the item type OutputDir is used as the value of the OutputDirList property, MSBuild converts or "flattens" the item type into to the semicolon-separated string "KeyFiles\\;Certificates\\".  
  
## Properties and Items in Tasks  
 Properties and items are used as inputs and outputs to MSBuild tasks. For more information, see [MSBuild Tasks](../vs140/msbuild-tasks.md).  
  
 Properties are passed to tasks as attributes. Within the task, an MSBuild property is represented by a property type whose value can be converted to and from a string. The supported property types include <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>, and any type that \<xref:System.Convert.ChangeType*> can handle.  
  
 Items are passed to tasks as \<xref:Microsoft.Build.Framework.ITaskItem*> objects. Within the task, \<xref:Microsoft.Build.Framework.ITaskItem.ItemSpec*> represents the value of the item and \<xref:Microsoft.Build.Framework.ITaskItem.GetMetadata*> retrieves its metadata.  
  
 The item list of an item type can be passed as an array of <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> objects. Beginning with the .NET Framework 3.5, items can be removed from an item list in a target by using the <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> attribute. Because items can be removed from an item list, it is possible for an item type to have zero items. If an item list is passed to a task, the code in the task should check for this possibility.  
  
## Property and Item Evaluation Order  
 During the evaluation phase of a build, imported files are incorporated into the build in the order in which they appear. Properties and items are defined in three passes in the following order:  
  
-   Properties are defined and modified in the order in which they appear.  
  
-   Item definitions are defined and modified in the order in which they appear.  
  
-   Items are defined and modified in the order in which they appear.  
  
 During the execution phase of a build, properties and items that are defined within targets are evaluated together in a single phase in the order in which they appear.  
  
 However, this is not the full story. When a property, item definition, or item is defined, its value is evaluated. The expression evaluator expands the string that specifies the value. The string expansion is dependent on the build phase. Here is a more detailed property and item evaluation order:  
  
-   During the evaluation phase of a build:  
  
    -   Properties are defined and modified in the order in which they appear. Property functions are executed. Property values in the form $(PropertyName) are expanded within expressions. The property value is set to the expanded expression.  
  
    -   Item definitions are defined and modified in the order in which they appear. Property functions have already been expanded within expressions. Metadata values are set to the expanded expressions.  
  
    -   Item types are defined and modified in the order in which they appear. Item values in the form @(ItemType) are expanded. Item transformations are also expanded. Property functions and values have already been expanded within expressions. The item list and metadata values are set to the expanded expressions.  
  
-   During the execution phase of a build:  
  
    -   Properties and items that are defined within targets are evaluated together in the order in which they appear. Property functions are executed and property values are expanded within expressions. Item values and item transformations are also expanded. The property values, item type values, and metadata values are set to the expanded expressions.  
  
### Subtle Effects of the Evaluation Order  
 In the evaluation phase of a build, property evaluation precedes item evaluation. Nevertheless, properties can have values that appear to depend on item values. Consider the following script.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Executing the Message task displays this message:  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 This is because the value of <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> is actually the string "@(KeyFile->'%(Version)')". Item and item transformations were not expanded when the property was first defined, so the <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> property was assigned the value of the unexpanded string.  
  
 During the execution phase of the build, when it processes the Message task, MSBuild expands the string "@(KeyFile->'%(Version)')" to yield "1.0.0.3".  
  
 Notice that the same message would appear even if the property and item groups were reversed in order.  
  
 As a second example, consider what can happen when property and item groups are located within targets:  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 The Message task displays this message:  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 This is because during the execution phase of the build, property and item groups defined within targets are evaluated top to bottom at the same time. When <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> is defined, <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> is unknown. Therefore, the item transformation expands to an empty string.  
  
 In this case, reversing the order of the property and item groups restores the original message:  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 The value of <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> is set to "1.0.0.3" and not to "@(KeyFile->'%(Version)')". The Message task displays this message:  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
## See Also  
 [MSBuild Advanced Concepts](../vs140/msbuild-advanced-concepts.md)