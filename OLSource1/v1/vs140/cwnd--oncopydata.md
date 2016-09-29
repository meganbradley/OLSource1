---
title: "CWnd::OnCopyData"
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
  - "CWnd::OnCopyData"
  - "OnCopyData"
  - "CWnd.OnCopyData"
  - "COPYDATASTRUCT"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnCopyData method"
  - "copying data"
  - "data [MFC]"
  - "COPYDATASTRUCT"
  - "data [MFC], copying"
ms.assetid: 0dbf3e98-92ef-4a4d-95fa-14a78bbcc593
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWnd::OnCopyData
This member function is called by the framework to copy data from one application to another.  
  
## Syntax  
  
```  
  
      afx_msg BOOL OnCopyData(  
   CWnd* pWnd,  
   COPYDATASTRUCT* pCopyDataStruct   
);  
```  
  
#### Parameters  
 `pWnd`  
 A pointer to a [CWnd](../vs140/cwnd-class.md) object that is sending the data.  
  
 `pCopyDataStruct`  
 A pointer to a [COPYDATASTRUCT](http://msdn.microsoft.com/library/windows/desktop/ms649010) structure that contains the data being sent.  
  
## Return Value  
 Returns **TRUE** if the receiving application successfully accepts the data. Otherwise, returns **FALSE**.  
  
## Remarks  
 The data being passed must not contain pointers or other references to objects not accessible to the application receiving the data.  
  
 While the data is being copied, it must not be changed by another thread of the sending process.  
  
 The receiving application should consider the data read-only. The structure pointed to by the parameter `pCopyDataStruct` is valid only during the transfer of data; however, the receiving application should not free the memory associated with the structure.  
  
 If the receiving application needs access to the data after this function returns, it must copy the data received to a local buffer.  
  
> [!NOTE]
>  This member function is called by the framework to allow your application to handle a Windows message. The parameters passed to your function reflect the parameters received by the framework when the message was received. If you call the base-class implementation of this function, that implementation will use the parameters originally passed with the message and not the parameters you supply to the function.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CWnd Class](../vs140/cwnd-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [WM_COPYDATA](http://msdn.microsoft.com/library/windows/desktop/ms649011)