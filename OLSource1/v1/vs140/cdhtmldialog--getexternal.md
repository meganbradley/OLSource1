---
title: "CDHtmlDialog::GetExternal"
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
  - "CDHtmlDialog::GetExternal"
  - "GetExternal"
  - "CDHtmlDialog.GetExternal"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetExternal method"
ms.assetid: 8b9ef23b-24ab-4a45-beab-de8a549fe978
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDHtmlDialog::GetExternal
Gets the host's <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> interface.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 *ppDispatch*  
 See *ppDispatch* in [IDocHostUIHandler::GetExternal](https://msdn.microsoft.com/en-us/library/aa753256.aspx) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Return Value  
 Returns <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> on success or **E_NOTIMPL** on failure.  
  
## Remarks  
 This member function is CDHtmlDialog's implementation of [IDocHostUIHandler::GetExternal](https://msdn.microsoft.com/en-us/library/aa753256.aspx), as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** afxdhtml.h  
  
## See Also  
 [CDHtmlDialog Class](../vs140/cdhtmldialog-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [IDocHostUIhandler Interface](https://msdn.microsoft.com/en-us/library/aa753260.aspx)   
 [CDHtmlDialog::CanAccessExternal](../vs140/cdhtmldialog--canaccessexternal.md)   
 [CDHtmlDialog::SetExternalDispatch](../vs140/cdhtmldialog--setexternaldispatch.md)