---
title: "CWnd::ExecuteDlgInit"
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
  - "CWnd.ExecuteDlgInit"
  - "ExecuteDlgInit"
  - "CWnd::ExecuteDlgInit"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "dialog resources"
  - "ExecuteDlgInit method"
  - "initiating dialog resources"
ms.assetid: fa400931-7671-4c58-ba23-54e4be3a8f86
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWnd::ExecuteDlgInit
Initiates a dialog resource.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 A pointer to a null-terminated string specifying the name of the resource.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 A pointer to a resource.  
  
## Return Value  
 **TRUE** if a dialog resource is executed; otherwise **FALSE**.  
  
## Remarks  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> will use resources bound to the executing module, or resources from other sources. To accomplish this, <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> finds a resource handle by calling <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>. If your MFC application does not use the shared DLL (MFCx0[U][D].DLL), **AfxFindResourceHandle** calls [AfxGetResourceHandle](../vs140/afxgetresourcehandle.md), which returns the current resource handle for the executable. If your MFC application that uses MFCx0[U][D].DLL, <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> traverses the **CDynLinkLibrary** object list of shared and extension DLLs looking for the correct resource handle.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CWnd Class](../vs140/cwnd-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDialog::OnInitDialog](../vs140/cdialog--oninitdialog.md)   
 [WM_INITDIALOG](http://msdn.microsoft.com/library/windows/desktop/ms645428)