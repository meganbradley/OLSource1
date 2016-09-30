---
title: "CDC::DeleteDC"
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
  - "CDC::DeleteDC"
  - "DeleteDC"
  - "CDC.DeleteDC"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "DeleteDC method"
  - "CDC class, initialization"
ms.assetid: 6ea981e2-bc44-4380-a380-1b80aebee672
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDC::DeleteDC
In general, do not call this function; the destructor will do it for you.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 Nonzero if the function completed successfully; otherwise 0.  
  
## Remarks  
 The <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> member function deletes the Windows device contexts that are associated with <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> in the current <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> object. If this <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> object is the last active device context for a given device, the device is notified and all storage and system resources used by the device are released.  
  
 An application should not call <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> if objects have been selected into the device context. Objects must first be selected out of the device context before it is deleted.  
  
 An application must not delete a device context whose handle was obtained by calling [CWnd::GetDC](../vs140/cwnd--getdc.md). Instead, it must call [CWnd::ReleaseDC](../vs140/cwnd--releasedc.md) to free the device context. The [CClientDC](../vs140/cclientdc-class.md) and [CWindowDC](../vs140/cwindowdc-class.md) classes are provided to wrap this functionality.  
  
 The <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> function is generally used to delete device contexts created with [CreateDC](../vs140/cdc--createdc.md), [CreateIC](../vs140/cdc--createic.md), or [CreateCompatibleDC](../vs140/cdc--createcompatibledc.md).  
  
## Example  
 See the example for [CPrintDialog::GetPrinterDC](../vs140/cprintdialog--getprinterdc.md).  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CDC Class](../vs140/cdc-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDC::CDC](../vs140/cdc--cdc.md)   
 [DeleteDC](http://msdn.microsoft.com/library/windows/desktop/dd183533)   
 [CDC::CreateDC](../vs140/cdc--createdc.md)   
 [CDC::CreateIC](../vs140/cdc--createic.md)   
 [CDC::CreateCompatibleDC](../vs140/cdc--createcompatibledc.md)   
 [CWnd::GetDC](../vs140/cwnd--getdc.md)   
 [CWnd::ReleaseDC](../vs140/cwnd--releasedc.md)