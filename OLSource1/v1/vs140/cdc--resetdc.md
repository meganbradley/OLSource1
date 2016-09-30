---
title: "CDC::ResetDC"
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
  - "CDC::ResetDC"
  - "ResetDC"
  - "CDC.ResetDC"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "paper orientation"
  - "CDC class, device context functions"
  - "paper bin"
  - "ResetDC method"
ms.assetid: b54a395c-6e2d-4304-8253-1e954510cdcd
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDC::ResetDC
Call this member function to update the device context wrapped by the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 *lpDevMode*  
 A pointer to a Windows <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> structure.  
  
## Return Value  
 Nonzero if the function is successful; otherwise 0.  
  
## Remarks  
 The device context is updated from the information specified in the Windows <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> structure. This member function only resets the attribute device context.  
  
 An application will typically use the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> member function when a window processes a <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> message. You can also use this member function to change the paper orientation or paper bins while printing a document.  
  
 You cannot use this member function to change the driver name, device name, or output port. When the user changes the port connection or device name, you must delete the original device context and create a new device context with the new information.  
  
 Before you call this member function, you must ensure that all objects (other than stock objects) that had been selected into the device context have been selected out.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CDC Class](../vs140/cdc-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDC::m_hAttribDC](../vs140/cdc--m_hattribdc.md)   
 [ResetDC](http://msdn.microsoft.com/library/windows/desktop/dd162925)   
 [WM_DEVMODECHANGE](http://msdn.microsoft.com/library/windows/desktop/dd145209)   
 [DEVMODE](http://msdn.microsoft.com/library/windows/desktop/dd183565)