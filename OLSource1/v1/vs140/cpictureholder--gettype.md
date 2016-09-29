---
title: "CPictureHolder::GetType"
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
  - "CPictureHolder.GetType"
  - "CPictureHolder::GetType"
  - "GetType"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetType method"
ms.assetid: b0495f43-169e-4855-8b03-ff2c562cffac
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CPictureHolder::GetType
Indicates whether the picture is a bitmap, metafile, or icon.  
  
## Syntax  
  
```  
  
short GetType( );  
```  
  
## Return Value  
 A value indicating the type of the picture. Possible values and their meanings are as follows:  
  
|Value|Meaning|  
|-----------|-------------|  
|**PICTYPE_UNINITIALIZED**|`CPictureHolder` object is unititialized.|  
|**PICTYPE_NONE**|`CPictureHolder` object is empty.|  
|**PICTYPE_BITMAP**|Picture is a bitmap.|  
|**PICTYPE_METAFILE**|Picture is a metafile.|  
|**PICTYPE_ICON**|Picture is an icon.|  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CPictureHolder Class](../vs140/cpictureholder-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)