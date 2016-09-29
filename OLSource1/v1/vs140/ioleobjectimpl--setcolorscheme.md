---
title: "IOleObjectImpl::SetColorScheme"
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
  - "IOleObjectImpl.SetColorScheme"
  - "IOleObjectImpl::SetColorScheme"
  - "SetColorScheme"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetColorScheme method"
ms.assetid: fe168748-3a1b-4184-890d-b31058aeab30
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IOleObjectImpl::SetColorScheme
Recommends a color scheme to the control's application, if any.  
  
## Syntax  
  
```  
  
      STDMETHOD(SetColorScheme)(  
   LOGPALETTE* /* pLogPal */  
);  
```  
  
## Return Value  
 Returns **E_NOTIMPL**.  
  
## Remarks  
 See [IOleObject::SetColorScheme](http://msdn.microsoft.com/library/windows/desktop/ms683971) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** atlctl.h  
  
## See Also  
 [IOleObjectImpl Class](../vs140/ioleobjectimpl-class.md)