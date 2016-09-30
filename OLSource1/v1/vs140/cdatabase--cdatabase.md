---
title: "CDatabase::CDatabase"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
f1_keywords: 
  - "CDatabase::CDatabase"
  - "CDatabase.CDatabase"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CDatabase class, construction"
  - "CDatabase class, constructor"
ms.assetid: 1491c94b-2cff-4133-b201-17e9b199e608
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDatabase::CDatabase
Constructs a <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 After constructing the object, you must call its <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> or **Open** member function to establish a connection to a specified data source.  
  
 You may find it convenient to embed the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> object in your document class.  
  
## Example  
 This example illustrates using <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> in a <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>-derived class.  
  
 [!code[NVC_MFCDatabase#9](../vs140/codesnippet/CPP/cdatabase--cdatabase_1.h)]  
  
 [!code[NVC_MFCDatabase#10](../vs140/codesnippet/CPP/cdatabase--cdatabase_2.cpp)]  
  
## Requirements  
 **Header:** afxdb.h  
  
## See Also  
 [CDatabase Class](../vs140/cdatabase-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDatabase::OpenEx](../vs140/cdatabase--openex.md)   
 [CDatabase::Open](../vs140/cdatabase--open.md)