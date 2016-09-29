---
title: "DECLARE_DHTMLEDITING_CMDMAP"
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
  - "DECLARE_DHTMLEDITING_CMDMAP"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "DECLARE_DHTMLEDITING_CMDMAP macro"
ms.assetid: c66f1d6f-b9e9-449f-81e9-7cd6ab16815c
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# DECLARE_DHTMLEDITING_CMDMAP
Declares a DHTML editing command map in a class.  
  
## Syntax  
  
```  
  
DECLARE_DHTMLEDITING_CMDMAP(  
className  
)  
  
```  
  
#### Parameters  
 `className`  
 The name of the class.  
  
## Remarks  
 This macro is to be used in the definition of [CHtmlEditView](../VS_csharp/chtmleditview-class.md)-derived classes.  
  
 Use [BEGIN_DHTMLEDITING_CMDMAP](../VS_csharp/begin_dhtmlediting_cmdmap.md) to implement the map.  
  
## Example  
 See [HTMLEdit Sample](../VS_csharp/visual-c---samples.md).  
  
## Requirements  
 **Header:** afxhtml.h  
  
## See Also  
 [Macros and Globals](../VS_csharp/mfc-macros-and-globals.md)   
 [DHTML Editing Command Maps](../VS_csharp/dhtml-editing-command-maps.md)