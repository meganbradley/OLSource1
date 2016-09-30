---
title: "Item Functions"
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
  - "msbuild, Item functions"
ms.assetid: 5e6df3cc-2db8-4cbd-8fdd-3ffd03ac0876
caps.latest.revision: 32
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Item Functions
Starting with MSBuild 4.0, code in tasks and targets can call item functions to get information about the items in the project. These functions simplify getting Distinct() items and are faster than looping through the items.  
  
## String Item Functions  
 You can use string methods and properties in the .NET Framework to operate on any item value. For \<xref:System.String*> methods, specify the method name. For \<xref:System.String*> properties, specify the property name after "get_".  
  
 For items that have multiple strings, the string method or property runs on each string.  
  
 The following example shows how to use these string item functions.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Intrinsic Item Functions  
 The table below lists the intrinsic functions available for items.  
  
|Function|Example|Description|  
|--------------|-------------|-----------------|  
|<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>|Returns the count of the items.|  
|<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>|Returns the equivalent of <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> for each item.|  
|<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>|Returns items that have distinct <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> values. Metadata is ignored. The comparison is case insensitive.|  
|<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>|Returns items that have distinct <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> values. Metadata is ignored. The comparison is case sensitive.|  
|<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>|Returns the items in reverse order.|  
|<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>|Returns a <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> to indicate whether any item has the given metadata name and value. The comparison is case insensitive.|  
|<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>|Returns items with their metadata cleared. Only the <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> is retained.|  
|<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>|Returns items that have the given metadata name. The comparison is case insensitive.|  
|<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>24\</CodeContentPlaceHolder>|Returns the values of the metadata that have the metadata name.|  
|<CodeContentPlaceHolder>25\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>26\</CodeContentPlaceHolder>|Returns items that have the given metadata name and value. The comparison is case insensitive.|  
  
 The following example shows how to use intrinsic item functions.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## See Also  
 [MSBuild Items](../vs140/msbuild-items.md)