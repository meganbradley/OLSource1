---
title: "COlePropertiesDialog::m_vp"
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
  - "COlePropertiesDialog.m_vp"
  - "COlePropertiesDialog::m_vp"
  - "m_vp"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "COlePropertiesDialog class, data members"
  - "m_vp"
ms.assetid: 26774799-7a10-47ba-b21e-889d85b14254
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COlePropertiesDialog::m_vp
A structure of type [OLEUIVIEWPROPS](http://msdn.microsoft.com/library/windows/desktop/ms693751), used to initialize the View page of the OLE Object Properties dialog box.  
  
## Syntax  
  
```  
  
OLEUIVIEWPROPS m_vp;  
  
```  
  
## Remarks  
 This page allows the user to toggle between "content" and "iconic" views of the object, and change its scaling within the container. It also allows the user access to the Change Icon dialog box when the object is being displayed as an icon.  
  
 For more information on the **OLEUIVIEWPROPS** structure, see the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** afxodlgs.h  
  
## See Also  
 [COlePropertiesDialog Class](../vs140/colepropertiesdialog-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)