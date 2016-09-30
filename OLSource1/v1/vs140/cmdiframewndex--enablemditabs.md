---
title: "CMDIFrameWndEx::EnableMDITabs"
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
  - "EnableMDITabs"
  - "CMDIFrameWndEx::EnableMDITabs"
  - "CMDIFrameWndEx.EnableMDITabs"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "EnableMDITabs method"
ms.assetid: 0cb3459e-a138-4268-b0a9-8b64fcaa1a93
caps.latest.revision: 21
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMDIFrameWndEx::EnableMDITabs
Enables or disables the MDI Tabs feature for the MDI frame window. When enabled, the frame window displays a tab for each MDI child window.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Specifies whether tabs are enabled.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Specifies whether icons should be displayed on the tabs.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Specifies the location of the tab labels.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Specifies whether to display tab close buttons.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 Specifies the style of tabs. Use <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> for regular tabs or <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> for Microsoft OneNote tabs.  
  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 Specifies whether custom tooltips are enabled.  
  
 <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
 If <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>, a **Close** button will be displayed on the active tab instead of on the right corner of the tab area.  
  
## Remarks  
 Call this method to enable or disable the MDI tabs feature for the MDI frame window. When enabled, all child windows are displayed as tabs.  
  
 The tab labels can be located at the top or bottom of the frame, depending on the setting of the parameter <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>. You may specify either <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> (the default setting) or <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>.  
  
 If <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>, an <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> message will be sent to the main frame window. Your code can handle this message and provide the framework with custom tooltips for MDI tabs.  
  
## Example  
 The following example shows how <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> is used in the [MDITabsDemo Sample: MFC Tabbed MDI Application](../vs140/visual-c---samples.md).  
  
 [!code[NVC_MFC_MDITabsDemo#3](../vs140/codesnippet/CPP/cmdiframewndex--enablemditabs_1.cpp)]  
  
## Requirements  
 **Header:** afxMDIFrameWndEx.h  
  
## See Also  
 [CMDIFrameWndEx Class](../vs140/cmdiframewndex-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)