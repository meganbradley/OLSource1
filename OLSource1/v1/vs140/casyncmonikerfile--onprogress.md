---
title: "CAsyncMonikerFile::OnProgress"
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
  - "BINDSTATUS"
  - "CAsyncMonikerFile.OnProgress"
  - "OnProgress"
  - "CAsyncMonikerFile::OnProgress"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "BINDSTATUS enumeration"
  - "OnProgress method"
ms.assetid: 8d810e74-8599-46c3-b09b-2f069d8237d0
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CAsyncMonikerFile::OnProgress
Called by the moniker repeatedly to indicate the current progress of this bind operation, typically at reasonable intervals during a lengthy operation.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Indicates the current progress of the bind operation relative to the expected maximum indicated in <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Indicates the expected maximum value of <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> for the duration of calls to <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> for this operation.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 Provides additional information regarding the progress of the bind operation. Valid values are taken from the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> enumeration. See Remarks for possible values.  
  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 Information about the current progress, depending on the value of <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>. See Remarks for possible values.  
  
## Remarks  
 Possible values for <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> (and the <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> for each value) are:  
  
 **BINDSTATUS_FINDINGRESOURCE**  
 The bind operation is finding the resource that holds the object or storage being bound to. The <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> provides the display name of the resource being searched for (for example, "www.microsoft.com").  
  
 **BINDSTATUS_CONNECTING**  
 The bind operation is connecting to the resource that holds the object or storage being bound to. The <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> provides the display name of the resource being connected to (for example, an IP address).  
  
 **BINDSTATUS_SENDINGREQUEST**  
 The bind operation is requesting the object or storage being bound to. The <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> provides the display name of the object (for example, a file name).  
  
 **BINDSTATUS_REDIRECTING**  
 The bind operation has been redirected to a different data location. The <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> provides the display name of the new data location.  
  
 **BINDSTATUS_USINGCACHEDCOPY**  
 The bind operation is retrieving the requested object or storage from a cached copy. The <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> is **NULL**.  
  
 **BINDSTATUS_BEGINDOWNLOADDATA**  
 The bind operation has begun receiving the object or storage being bound to. The <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> provides the display name of the data location.  
  
 **BINDSTATUS_DOWNLOADINGDATA**  
 The bind operation continues to receive the object or storage being bound to. The <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> provides the display name of the data location.  
  
 **BINDSTATUS_ENDDOWNLOADDATA**  
 The bind operation has finished receiving the object or storage being bound to. The <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> provides the display name of the data location.  
  
 **BINDSTATUS_CLASSIDAVAILABLE**  
 An instance of the object being bound to is just about to be created. The <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> provides the CLSID of the new object in string format, allowing the client an opportunity to cancel the bind operation, if desired.  
  
## Requirements  
 **Header:** afxole.h  
  
## See Also  
 [CAsyncMonikerFile Class](../vs140/casyncmonikerfile-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)