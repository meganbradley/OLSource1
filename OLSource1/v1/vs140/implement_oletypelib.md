---
title: "IMPLEMENT_OLETYPELIB"
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
  - "IMPLEMENT_OLETYPELIB"
  - "AFXDISP/IMPLEMENT_OLETYPELIB"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "IMPLEMENT_OLETYPELIB macro"
ms.assetid: aa6f2754-ae03-4278-95d4-6f5a1eceeb05
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IMPLEMENT_OLETYPELIB
Implements the control's <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> member function.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 *class_name*  
 The name of the control class related to the type library.  
  
 *tlid*  
 The ID number of the type library.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The type library major version number.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The type library minor version number.  
  
## Remarks  
 This macro must appear in the implementation file for any control class that uses the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> macro.  
  
## Requirements  
 **Header:** afxdisp.h  
  
## See Also  
 [Macros and Globals](../vs140/mfc-macros-and-globals.md)   
 [DECLARE_OLETYPELIB](../vs140/declare_oletypelib.md)