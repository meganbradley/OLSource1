---
title: "CReBarCtrl::GetBandInfo"
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
  - "CReBarCtrl::GetBandInfo"
  - "GetBandInfo"
  - "CReBarCtrl.GetBandInfo"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CReBarCtrl class, attributes"
  - "GetBandInfo method"
ms.assetid: d51a9c07-24b3-4719-a6c0-f32400b3c79d
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CReBarCtrl::GetBandInfo
Implements the behavior of the Win32 message [RB_GETBANDINFO](http://msdn.microsoft.com/library/windows/desktop/bb774451) as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Zero-based index of the band for which the information will be retrieved.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 A pointer to a [REBARBANDINFO](http://msdn.microsoft.com/library/windows/desktop/bb774393) structure to receive the band information. You must set the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> member of this structure to <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> and set the **fMask** member to the items you want to retrieve before sending this message.  
  
## Return Value  
 Nonzero if successful; otherwise zero.  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CReBarCtrl Class](../vs140/crebarctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CReBarCtrl::SetBandInfo](../vs140/crebarctrl--setbandinfo.md)   
 [CReBarCtrl::GetBandCount](../vs140/crebarctrl--getbandcount.md)   
 [CReBarCtrl::DeleteBand](../vs140/crebarctrl--deleteband.md)   
 [CReBarCtrl::InsertBand](../vs140/crebarctrl--insertband.md)   
 [CReBarCtrl::ShowBand](../vs140/crebarctrl--showband.md)