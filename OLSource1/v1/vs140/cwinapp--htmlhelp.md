---
title: "CWinApp::HtmlHelp"
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
  - "CWinApp.HtmlHelp"
  - "CWinApp::HtmlHelp"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "HtmlHelp method"
ms.assetid: a1201f03-ae9d-4c50-9bae-e53aa23dcde8
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWinApp::HtmlHelp
Call this member function to invoke the HTMLHelp application.  
  
## Syntax  
  
```  
  
      virtual void HtmlHelp(  
   DWORD_PTR dwData,  
   UINT nCmd = 0x000F   
);  
```  
  
#### Parameters  
 `dwData`  
 Specifies additional data. The value used depends on the value of the `nCmd` parameter.  
  
 `nCmd`  
 Specifies the type of help requested. For a list of possible values and how they affect the `dwData` parameter, see the `uCommand` parameter described in [About the HTMLHelp API Function](vsconHowcallingthehtmlhelpapi) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Remarks  
 The framework also calls this function to invoke the HTMLHelp application.  
  
 The framework will automatically close the HTMLHelp application when your application terminates.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CWinApp Class](../vs140/cwinapp-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CWinApp::WinHelp](../vs140/cwinapp--winhelp.md)   
 [\<PAVE OVER> Displaying F1 Help for a Dialog Box or Menu Option_deleted](../Topic/%3CPAVE%20OVER%3E%20Displaying%20F1%20Help%20for%20a%20Dialog%20Box%20or%20Menu%20Option_deleted.md)