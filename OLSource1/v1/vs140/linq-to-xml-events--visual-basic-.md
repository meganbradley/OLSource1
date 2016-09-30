---
title: "LINQ to XML Events (Visual Basic)"
ms.custom: na
ms.date: "09/22/2016"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-visual-basic"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "VB"
ms.assetid: 34923928-b99c-4004-956e-38f6db25e910
caps.latest.revision: 7
---
# LINQ to XML Events (Visual Basic)
[!INCLUDE[sqltecxlinq](../vs140/includes/sqltecxlinq_md.md)] events enable you to be notified when an XML tree is altered.  
  
 You can add events to an instance of any \<xref:System.Xml.Linq.XObject*>. The event handler will then receive events for modifications to that \<xref:System.Xml.Linq.XObject*> and any of its descendants. For example, you can add an event handler to the root of the tree, and handle all modifications to the tree from that event handler.  
  
 For examples of [!INCLUDE[sqltecxlinq](../vs140/includes/sqltecxlinq_md.md)] events, see \<xref:System.Xml.Linq.XObject.Changing*> and \<xref:System.Xml.Linq.XObject.Changed*>.  
  
## Types and Events  
 You use the following types when working with events:  
  
|Type|Description|  
|----------|-----------------|  
|\<xref:System.Xml.Linq.XObjectChange*>|Specifies the event type when an event is raised for an \<xref:System.Xml.Linq.XObject*>.|  
|\<xref:System.Xml.Linq.XObjectChangeEventArgs*>|Provides data for the \<xref:System.Xml.Linq.XObject.Changing*> and \<xref:System.Xml.Linq.XObject.Changed*> events.|  
  
 The following events are raised when you modify an XML tree:  
  
|Event|Description|  
|-----------|-----------------|  
|\<xref:System.Xml.Linq.XObject.Changing*>|Occurs just before this \<xref:System.Xml.Linq.XObject*> or any of its descendants is going to change.|  
|\<xref:System.Xml.Linq.XObject.Changed*>|Occurs when an \<xref:System.Xml.Linq.XObject*> has changed or any of its descendants have changed.|  
  
## Example  
  
### Description  
 Events are useful when you want to maintain some aggregate information in an XML tree. For example, you may want maintain an invoice total that is the sum of the line items of the invoice. This example uses events to maintain the total of all of the child elements under the complex element <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>.  
  
### Code  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
### Comments  
 This code produces the following output:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## See Also  
 [Advanced LINQ to XML Programming (Visual Basic)](../vs140/advanced-linq-to-xml-programming--visual-basic-.md)