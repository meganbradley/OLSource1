---
title: "CDaoDatabase::CDaoDatabase"
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
  - "CDaoDatabase::CDaoDatabase"
  - "CDaoDatabase.CDaoDatabase"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "databases [C++], constructing"
  - "DAO [C++], constructors"
  - "CDaoDatabase class, constructor"
ms.assetid: 849e6244-6a2f-4d0c-9e2e-dfffe47f6b02
caps.latest.revision: 18
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDaoDatabase::CDaoDatabase
Constructs a <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 *pWorkspace*  
 A pointer to the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> object that will contain the new database object. If you accept the default value of **NULL**, the constructor creates a temporary <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> object that uses the default DAO workspace. You can get a pointer to the workspace object via the [m_pWorkspace](../vs140/cdaodatabase--m_pworkspace.md) data member.  
  
## Remarks  
 After constructing the object, if you are creating a new Microsoft Jet (.MDB) database, call the object's [Create](../vs140/cdaodatabase--create.md) member function. If you are, instead, opening an existing database, call the object's [Open](../vs140/cdaodatabase--open.md) member function.  
  
 When you finish with the object, you should call its [Close](../vs140/cdaodatabase--close.md) member function and then destroy the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> object.  
  
 You might find it convenient to embed the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> object in your document class.  
  
> [!NOTE]
>  A <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> object is also created implicitly if you open a [CDaoRecordset](../vs140/cdaorecordset-class.md) object without passing a pointer to an existing <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> object. This database object is closed when you close the recordset object.  
  
## Requirements  
 **Header:** afxdao.h  
  
## See Also  
 [CDaoDatabase Class](../vs140/cdaodatabase-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)