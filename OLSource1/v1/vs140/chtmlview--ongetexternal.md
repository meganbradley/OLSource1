---
title: "CHtmlView::OnGetExternal"
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
  - "CHtmlView::OnGetExternal"
  - "OnGetExternal"
  - "CHtmlView.OnGetExternal"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnGetExternal method"
ms.assetid: 97803cb3-d9ed-4499-abbd-1cc2ebd442d1
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CHtmlView::OnGetExternal
Called by Internet Explorer or MSHTML to obtain the host's <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> interface.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 *lppDispatch*  
 A pointer to the address that receives the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> interface pointer of the host application. If the host exposes an Automation interface, it can provide a reference to Internet Explorer or MSHTML through this parameter. The contents of this parameter should always be initialized to **NULL**, even if the method fails.  
  
## Return Value  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> if successful, or an OLE-defined error code otherwise.  
  
## Remarks  
 Override <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> to react to the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> notification from the Microsoft Web Browser control. See [IDocHostUIHandler::GetExternal](https://msdn.microsoft.com/en-us/library/aa753256.aspx) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)] for more information.  
  
## Requirements  
 **Header:** afxhtml.h  
  
## See Also  
 [CHtmlView Class](../vs140/chtmlview-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CHtmlView::OnGetHostInfo](../vs140/chtmlview--ongethostinfo.md)