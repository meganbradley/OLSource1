---
title: "BEGIN_OLEFACTORY"
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
  - "BEGIN_OLEFACTORY"
  - "AFXCTL/BEGIN_OLEFACTORY"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "BEGIN_OLEFACTORY macro"
ms.assetid: d834f2ca-7a4a-49cd-8e4b-1bc4adb15af9
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# BEGIN_OLEFACTORY
Begins the declaration of your class factory in the header file of your control class.  
  
## Syntax  
  
```  
  
BEGIN_OLEFACTORY(  
class_name )  
```  
  
#### Parameters  
 *class_name*  
 Specifies the name of the control class whose class factory this is.  
  
## Remarks  
 Declarations of class factory licensing functions should begin immediately after `BEGIN_OLEFACTORY`.  
  
## Requirements  
 **Header:** afxctl.h  
  
## See Also  
 [Macros and Globals](../VS_csharp/mfc-macros-and-globals.md)   
 [END_OLEFACTORY](../VS_csharp/end_olefactory.md)   
 [DECLARE_OLECREATE_EX](../VS_csharp/declare_olecreate_ex.md)