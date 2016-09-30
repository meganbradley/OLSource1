---
title: "Item Element (MSBuild)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "VB"
  - "CSharp"
  - "C++"
  - "jsharp"
helpviewer_keywords: 
  - "Item Element [MSBuild]"
  - "<Item> Element [MSBuild]"
ms.assetid: dcef5f91-0613-4bfc-8ee9-d7004bb6d3a9
caps.latest.revision: 33
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Item Element (MSBuild)
Contains a user-defined item and its metadata. Every item that is used in a [!INCLUDE[vstecmsbuild](../vs140/includes/vstecmsbuild_md.md)] project must be specified as a child of an <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> element.  
  
 \<Project>  
 \<ItemGroup>  
 \<Item>  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Attributes and Elements  
 The following sections describe attributes, child elements, and parent elements.  
  
### Attributes  
  
|Attribute|Description|  
|---------------|-----------------|  
|<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>|Required attribute.\<br />\<br /> The file or wildcard to include in the list of items.|  
|<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>|Optional attribute.\<br />\<br /> The file or wildcard to exclude from the list of items.|  
|<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>|Optional attribute.\<br />\<br /> The condition to be evaluated. For more information, see [MSBuild Conditions](../vs140/msbuild-conditions.md).|  
|<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>|Optional attribute.\<br />\<br /> The file or wildcard to remove from the list of items.\<br />\<br /> This attribute is valid only if it's specified for an item in an <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> that's in a <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>.|  
|<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>|Optional attribute.\<br />\<br /> The metadata for the source items to add to the target items. Only the metadata whose names are specified in the semicolon-delimited list are transferred from a source item to a target item. For more information, see [MSBuild Items](../vs140/msbuild-items.md).\<br />\<br /> This attribute is valid only if it's specified for an item in an <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> that's in a <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>.|  
|<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>|Optional attribute.\<br />\<br /> The metadata for the source items to not transfer to the target items. All metadata is transferred from a source item to a target item except metadata whose names are contained in the semicolon-delimited list of names. For more information, see [MSBuild Items](../vs140/msbuild-items.md).\<br />\<br /> This attribute is valid only if it's specified for an item in an <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> that's in a <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>.|  
|<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>|Optional attribute.\<br />\<br /> Specifies whether an item should be added to the target group if it's an exact duplicate of an existing item. If the source and target item have the same <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> value but different metadata, the item is added even if <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> is set to <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>. For more information, see [MSBuild Items](../vs140/msbuild-items.md).\<br />\<br /> This attribute is valid only if it's specified for an item in an <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> that's in a <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>.|  
  
### Child Elements  
  
|Element|Description|  
|-------------|-----------------|  
|[ItemMetadata](../vs140/itemmetadata-element--msbuild-.md)|A user-defined item metadata key, which contains the item metadata value. There may be zero or more <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> elements in an item.|  
  
### Parent Elements  
  
|Element|Description|  
|-------------|-----------------|  
|[ItemGroup](../vs140/itemgroup-element--msbuild-.md)|Grouping element for items.|  
  
## Remarks  
 <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> elements define inputs into the build system, and are grouped into item collections based on their user-defined collection names. These item collections can be used as parameters for [tasks](../vs140/msbuild-tasks.md), which use the individual items in the collections to perform the steps of the build process. For more information, see [MSBuild Items](../vs140/msbuild-items.md).  
  
 Using the notation <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>*myType*<CodeContentPlaceHolder>24\</CodeContentPlaceHolder> enables a collection of items of type *myType* to be expanded into a semicolon-delimited list of strings, and passed to a parameter. If the parameter is of type <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>, then the value of the parameter is the list of elements, separated by semicolons. If the parameter is an array of strings (<CodeContentPlaceHolder>26\</CodeContentPlaceHolder>), then each element is inserted into the array based on the location of the semicolons. If the task parameter is of type \<xref:Microsoft.Build.Framework.ITaskItem*><CodeContentPlaceHolder>27\</CodeContentPlaceHolder>, then the value is the contents of the item collection together with any metadata attached. To delimit each item by using a character other than a semicolon, use the syntax <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>*myType*<CodeContentPlaceHolder>29\</CodeContentPlaceHolder>*separator*<CodeContentPlaceHolder>30\</CodeContentPlaceHolder>.  
  
 The [!INCLUDE[vstecmsbuild](../vs140/includes/vstecmsbuild_md.md)] engine can evaluate wildcards such as <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> and recursive wildcards such as <CodeContentPlaceHolder>33\</CodeContentPlaceHolder>. For more information, see [MSBuild Items](../vs140/msbuild-items.md).  
  
## Example  
 The following code example shows how to declare two items of type <CodeContentPlaceHolder>34\</CodeContentPlaceHolder>. The second declared item contains metadata that has <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> set to <CodeContentPlaceHolder>36\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## See Also  
 [MSBuild Items](../vs140/msbuild-items.md)   
 [MSBuild Properties](../vs140/msbuild-properties.md)   
 [MSBuild Project File Schema Reference](../vs140/msbuild-project-file-schema-reference.md)