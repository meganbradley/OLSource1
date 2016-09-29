---
title: "IMPLEMENT_OLECREATE"
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
  - "IMPLEMENT_OLECREATE"
  - "AFXDISP/IMPLEMENT_OLECREATE"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "IMPLEMENT_OLECREATE macro"
  - "run-time object model services macros"
ms.assetid: 9cf0c9d2-ec3b-4593-89bd-2047347409db
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IMPLEMENT_OLECREATE
Either this macro or [IMPLEMENT_OLECREATE_FLAGS](../vs140/implement_olecreate_flags.md) must appear in the implementation file for any class that uses `DECLARE_OLECREATE`.  
  
## Syntax  
  
```  
  
IMPLEMENT_OLECREATE(  
class_name  
, external_name, l, w1, w2, b1, b2, b3, b4, b5, b6, b7, b8 )  
```  
  
#### Parameters  
 *class_name*  
 The actual name of the class.  
  
 *external_name*  
 The object name exposed to other applications (enclosed in quotation marks).  
  
 *l*, *w1*, *w2*, *b1*, *b2*, *b3*, *b4*, *b5*, *b6*, *b7*, *b8*  
 Components of the class's **CLSID**.  
  
## Remarks  
  
> [!NOTE]
>  If you use `IMPLEMENT_OLECREATE`, by default, you support only the single threading model. If you use `IMPLEMENT_OLECREATE_FLAGS`, you can specify which threading model your object supports by using the `nFlags` parameter.  
  
 The external name is the identifier exposed to other applications. Client applications use the external name to request an object of this class from an automation server.  
  
 The OLE class ID is a unique 128-bit identifier for the object. It consists of one **long**, two **WORD**s, and eight **BYTE**s, as represented by *l*, *w1*, *w2*, and *b1* through *b8* in the syntax description. The Application Wizard and code wizards create unique OLE class IDs for you as required.  
  
## Requirements  
 **Header:** afxdisp.h  
  
## See Also  
 [Macros and Globals](../vs140/mfc-macros-and-globals.md)   
 [DECLARE_OLECREATE](../vs140/declare_olecreate.md)   
 [CLSID Key](http://msdn.microsoft.com/library/windows/desktop/ms691424)