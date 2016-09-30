---
title: "Expression of type &lt;type&gt; is not queryable"
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
  - "bc36593"
  - "vbc36593"
dev_langs: 
  - "VB"
helpviewer_keywords: 
  - "BC36593"
ms.assetid: 6f1f5860-bf97-4885-9ebb-bc87d028095c
caps.latest.revision: 9
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Expression of type &lt;type&gt; is not queryable
Expression of type \<type> is not queryable. Make sure you are not missing an assembly reference and/or namespace import for the LINQ provider.  
  
 Queryable types are defined in the \<xref:System.Linq*>, \<xref:System.Data.Linq*>, and \<xref:System.Xml.Linq*> namespaces. You must import one or more of these namespaces to perform LINQ queries.  
  
 The \<xref:System.Linq*> namespace enables you to query objects such as collections and arrays by using LINQ.  
  
 The \<xref:System.Data.Linq*> namespace enables you to query ADO.NET Datasets and SQL Server databases by using LINQ.  
  
 The \<xref:System.Xml.Linq*> namespace enables you to query XML by using LINQ and to use XML features in Visual Basic.  
  
 **Error ID:** BC36593  
  
### To correct this error  
  
1.  Add an <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> statement for the \<xref:System.Linq*>, \<xref:System.Data.Linq*>, or \<xref:System.Xml.Linq*> namespace to your code file. You can also import namespaces for your project by using the **References** page of the Project Designer (**My Project**).  
  
2.  Ensure that the type that you have identified as the source of your query is a queryable type. That is, a type that implements <xref:System.Collections.Generic.IEnumerable<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>1*>.  
  
## See Also  
 \<xref:System.Linq*>   
 \<xref:System.Data.Linq*>   
 \<xref:System.Xml.Linq*>   
 [Introduction to LINQ in Visual Basic](../vs140/introduction-to-linq-in-visual-basic.md)   
 [LINQ in Visual Basic](../vs140/linq-in-visual-basic.md)   
 [XML in Visual Basic](../vs140/xml-in-visual-basic.md)   
 [References and the Imports Statement](../vs140/references-and-the-imports-statement--visual-basic-.md)   
 [Imports Statement (.NET Namespace and Type)](../vs140/imports-statement--.net-namespace-and-type-.md)   
 [References Page, Project Designer (Visual Basic)](../vs140/references-page--project-designer--visual-basic-.md)