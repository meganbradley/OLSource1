---
title: "DECLARE_OLECREATE"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "AFXDISP/DECLARE_OLECREATE"
  - "DECLARE_OLECREATE"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "run-time object model services macros"
  - "DECLARE_OLECREATE macro"
ms.assetid: 8d9fd746-b7dd-45f3-92f5-82e8ac7d496d
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# DECLARE_OLECREATE
Enables objects of <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>-derived classes to be created through OLE automation.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 *class_name*  
 The actual name of the class.  
  
## Remarks  
 This macro enables other OLE-enabled applications to create objects of this type.  
  
 Add the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> macro in the .h module for the class, and then include that module in all .cpp modules that need access to objects of this class.  
  
 If <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> is included in the class declaration, then <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> must be included in the class implementation. A class declaration using <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> must also use <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>.  
  
## Requirements  
 **Header**: afxdisp.h  
  
## See Also  
 [Macros and Globals](../vs140/mfc-macros-and-globals.md)   
 [IMPLEMENT_OLECREATE](../vs140/implement_olecreate.md)   
 [DECLARE_DYNCREATE](../vs140/declare_dyncreate.md)   
 [DECLARE_SERIAL](../vs140/declare_serial.md)