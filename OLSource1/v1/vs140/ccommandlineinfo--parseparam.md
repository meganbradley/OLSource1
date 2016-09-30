---
title: "CCommandLineInfo::ParseParam"
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
  - "CCommandLineInfo.ParseParam"
  - "CCommandLineInfo::ParseParam"
  - "ParseParam"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "ParseParam method"
ms.assetid: 2dae5356-d15e-4000-bcdc-ce4ee1bcba75
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CCommandLineInfo::ParseParam
The framework calls this function to parse/interpret individual parameters from the command line. The second version differs from the first only in Unicode projects.  
  
## Syntax  
  
```  
  
      virtual void ParseParam(   
   const char* pszParam,   
   BOOL bFlag,   
   BOOL bLast   
);  
virtual void ParseParam(   
   const TCHAR* pszParam,    
   BOOL bFlag,   
   BOOL bLast  
);  
```  
  
#### Parameters  
 `pszParam`  
 The parameter or flag.  
  
 *bFlag*  
 Indicates whether `pszParam` is a parameter or a flag.  
  
 `bLast`  
 Indicates if this is the last parameter or flag on the command line.  
  
## Remarks  
 [CWinApp::ParseCommandLine](../vs140/cwinapp--parsecommandline.md) calls `ParseParam` once for each parameter or flag on the command line, passing the argument to `pszParam`. If the first character of the parameter is a '**-**' or a '**/**', then it is removed and *bFlag* is set to **TRUE**. When parsing the final parameter, `bLast` is set to **TRUE**.  
  
 The default implementation of this function recognizes the following flags: **/p**, **/pt**, **/dde**, **/Automation**, and **/Embedding**, as shown in the following table:  
  
|Command-line argument|Command executed|  
|----------------------------|----------------------|  
|*app*|New file.|  
|*app* filename|Open file.|  
|*app* **/p** filename|Print file to default printer.|  
|*app* **/pt** filename printer driver port|Print file to the specified printer.|  
|*app* **/dde**|Start up and await DDE command.|  
|*app* **/Automation**|Start up as an OLE automation server.|  
|*app* **/Embedding**|Start up to edit an embedded OLE item.|  
|*app* **/Register**\<br />\<br /> *app* **/Regserver**|Informs the application to perform any registration tasks.|  
|*app* **/Unregister**\<br />\<br /> *app* **/Unregserver**|Informs the application to perform any un-registration tasks.|  
  
 This information is stored in [m_bRunAutomated](../vs140/ccommandlineinfo--m_brunautomated.md), [m_bRunEmbedded](../vs140/ccommandlineinfo--m_brunembedded.md), and [m_nShellCommand](../vs140/ccommandlineinfo--m_nshellcommand.md). Flags are marked by either a forward-slash '**/**' or hyphen '**-**'.  
  
 The default implementation puts the first non-flag parameter into [m_strFileName](../vs140/ccommandlineinfo--m_strfilename.md). In the case of the **/pt** flag, the default implementation puts the second, third, and fourth non-flag parameters into [m_strPrinterName](../vs140/ccommandlineinfo--m_strprintername.md), [m_strDriverName](../vs140/ccommandlineinfo--m_strdrivername.md), and [m_strPortName](../vs140/ccommandlineinfo--m_strportname.md), respectively.  
  
 The default implementation also sets [m_bShowSplash](../vs140/ccommandlineinfo--m_bshowsplash.md) to **TRUE** only in the case of a new file. In the case of a new file, the user has taken action involving the application itself. In any other case, including opening existing files using the shell, the user action involves the file directly. In a document-centric standpoint, the splash screen does not need to announce the application starting up.  
  
 Override this function in your derived class to handle other flag and parameter values.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CCommandLineInfo Class](../vs140/ccommandlineinfo-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CWinApp::ParseCommandLine](../vs140/cwinapp--parsecommandline.md)