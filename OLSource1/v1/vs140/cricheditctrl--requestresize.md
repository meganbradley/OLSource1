---
title: "CRichEditCtrl::RequestResize"
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
  - "CRichEditCtrl.RequestResize"
  - "RequestResize"
  - "CRichEditCtrl::RequestResize"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "RequestResize method"
ms.assetid: 07d75fb8-e5c3-4708-9303-0f9856302397
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CRichEditCtrl::RequestResize
Forces this <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> object to send **EN_REQUESTRESIZE** notification messages to its parent window.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 This function is useful during [CWnd::OnSize](../vs140/cwnd--onsize.md) processing for a bottomless <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> object.  
  
 For more information, see the [EM_REQUESTRESIZE](http://msdn.microsoft.com/library/windows/desktop/bb774220) message and the **Bottomless Rich Edit Controls** section of [About Rich Edit Controls](http://msdn.microsoft.com/library/windows/desktop/bb787873) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CRichEditCtrl Class](../vs140/cricheditctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CWnd::OnSize](../vs140/cwnd--onsize.md)   
 [CRichEditCtrl::Create](../vs140/cricheditctrl--create.md)