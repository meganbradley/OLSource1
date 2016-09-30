---
title: "CWinApp::m_dwRestartManagerSupportFlags"
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
  - "CWinApp::m_dwRestartManagerSupportFlags"
  - "m_dwRestartManagerSupportFlags"
  - "CWinApp.m_dwRestartManagerSupportFlags"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "m_dwRestartManagerSupportFlags"
  - "CWinApp class, data members"
ms.assetid: db3ecf08-98a2-4734-85a1-741875292ca9
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWinApp::m_dwRestartManagerSupportFlags
Flags that determine how the restart manager behaves.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 To enable the restart manager, set <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> to the behavior that you want. The following table shows the flags that are available.  
  
|||  
|-|-|  
|Flag|Description|  
|<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>|The application is registered by using [CWinApp::RegisterWithRestartManager](../vs140/cwinapp--registerwithrestartmanager.md). The restart manager is responsible for restarting the application if it unexpectedly exits.|  
|-   <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>|The application is registered with the restart manager and the restart manager calls the recovery callback function when it restarts the application. The default recovery callback function is [CWinApp::ApplicationRecoveryCallback](../vs140/cwinapp--applicationrecoverycallback.md).|  
|-   <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>|Autosave is enabled and the restart manager autosaves any open documents when the application restarts.|  
|-   <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>|Autosave is enabled and the restart manager autosaves any open documents at a regular interval. The interval is defined by [CWinApp::m_nAutosaveInterval](../vs140/cwinapp--m_nautosaveinterval.md).|  
|-   <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>|The restart manager opens previously open documents after restarting the application from an unexpected exit. The [CDataRecoveryHandler Class](../vs140/cdatarecoveryhandler-class.md) handles storing the list of open documents and restoring them.|  
|-   <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>|The restart manager prompts the user to restore autosaved files after restarting the application. The <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> class queries the user.|  
|-   <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>|The union of <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>.|  
|-   <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>|The union of <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>.|  
|-   <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>|The union of <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>.|  
|-   <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>|The union of <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>.|  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CWinApp Class](../vs140/cwinapp-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [How to: Add Restart Manager Support](../vs140/how-to--add-restart-manager-support.md)