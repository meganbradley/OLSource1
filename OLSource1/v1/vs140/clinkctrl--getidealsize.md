---
title: "CLinkCtrl::GetIdealSize"
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
  - "CLinkCtrl::GetIdealSize"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetIdealSize method"
ms.assetid: 3a025230-a9dc-4aae-962e-51a111e4aae9
caps.latest.revision: 18
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CLinkCtrl::GetIdealSize
Calculates the preferred height of the link text for the current link control, depending on the specified width of the link.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|[in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>|The maximum width of the link, in pixels.|  
|[out] *<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>|A pointer to a Windows [SIZE](http://msdn.microsoft.com/library/windows/desktop/dd145106) structure. When this method returns, the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> member of the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> structure contains the ideal link text height for the link text width that is specified by <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>. The <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> member of the structure contains the link text width that is actually needed.|  
  
## Return Value  
 The preferred height of the link text, in pixels. The return value is the same as the value of the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> member of the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> structure.  
  
## Remarks  
 For an example of the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> method, see the example in [CLinkCtrl::Create](../vs140/clinkctrl--create.md).  
  
 This method sends the [LM_GETIDEALSIZE](http://msdn.microsoft.com/library/windows/desktop/bb760718) message, which is described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** afxcmn.h  
  
 This method is supported in [!INCLUDE[windowsver](../vs140/includes/windowsver_md.md)] and later.  
  
 Additional requirements for this method are described in [Build Requirements for Vista Common Controls](../vs140/build-requirements-for-windows-vista-common-controls.md).  
  
## See Also  
 [CLinkCtrl Class](../vs140/clinkctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [LM_GETIDEALSIZE](http://msdn.microsoft.com/library/windows/desktop/bb760718)   
 [SIZE](http://msdn.microsoft.com/library/windows/desktop/dd145106)   
 [CLinkCtrl::GetIdealHeight](../vs140/clinkctrl--getidealheight.md)