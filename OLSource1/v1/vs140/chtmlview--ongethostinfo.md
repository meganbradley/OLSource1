---
title: "CHtmlView::OnGetHostInfo"
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
  - "CHtmlView.OnGetHostInfo"
  - "OnGetHostInfo"
  - "CHtmlView::OnGetHostInfo"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnGetHostInfo method"
ms.assetid: 93753f7a-0f68-472f-9962-c2cedd066171
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CHtmlView::OnGetHostInfo
Retrieves the UI capabilities of the Internet Explorer or MSHTML host.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Address of a [DOCHOSTUIINFO](https://msdn.microsoft.com/en-us/library/aa770044.aspx) structure that receives the host's UI capabilities.  
  
## Return Value  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> if successful, or an OLE-defined error code otherwise.  
  
## Remarks  
 Override <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> to react to the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> notification from the Microsoft Web Browser control. See [IDocHostUIHandler::GetHostInfo](https://msdn.microsoft.com/en-us/library/aa753257.aspx) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)] for more information.  
  
## Requirements  
 **Header:** afxhtml.h  
  
## See Also  
 [CHtmlView Class](../vs140/chtmlview-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CHtmlView::OnGetExternal](../vs140/chtmlview--ongetexternal.md)