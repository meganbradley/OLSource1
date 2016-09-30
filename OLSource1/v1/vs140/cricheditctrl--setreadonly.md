---
title: "CRichEditCtrl::SetReadOnly"
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
  - "CRichEditCtrl.SetReadOnly"
  - "CRichEditCtrl::SetReadOnly"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetReadOnly method"
ms.assetid: 3fd897a6-ec1c-487a-8e44-b77a9a7c8ccb
caps.latest.revision: 18
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CRichEditCtrl::SetReadOnly
Changes the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> option for this <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Indicates if this <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> object should be read only.  
  
## Return Value  
 Nonzero if successful; otherwise, 0.  
  
## Remarks  
 For a brief description of this option, see [SetOptions](../vs140/cricheditctrl--setoptions.md). You can use this function to set all the options for this <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> object.  
  
 For more information, see [EM_SETREADONLY](http://msdn.microsoft.com/library/windows/desktop/bb761655) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Example  
 [!code[NVC_MFC_CRichEditCtrl#29](../vs140/codesnippet/CPP/cricheditctrl--setreadonly_1.cpp)]  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CRichEditCtrl Class](../vs140/cricheditctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CRichEditCtrl::Create](../vs140/cricheditctrl--create.md)   
 [CRichEditCtrl::SetOptions](../vs140/cricheditctrl--setoptions.md)