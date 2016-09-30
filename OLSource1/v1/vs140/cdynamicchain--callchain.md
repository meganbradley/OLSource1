---
title: "CDynamicChain::CallChain"
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
  - "ATL.CDynamicChain.CallChain"
  - "CDynamicChain::CallChain"
  - "CDynamicChain.CallChain"
  - "ATL::CDynamicChain::CallChain"
  - "CallChain"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CallChain method"
ms.assetid: d958dfcd-9e01-497e-a387-4290e5da2f9c
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDynamicChain::CallChain
Directs the Windows message to another object's message map.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 [in] The unique identifier associated with the chained object and its message map.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 [in] The handle to the window receiving the message.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 [in] The message sent to the window.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 [in] Additional message-specific information.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 [in] Additional message-specific information.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 [out] The result of the message processing.  
  
## Return Value  
 **TRUE** if the message is fully processed; otherwise, **FALSE**.  
  
## Remarks  
 For the window procedure to invoke <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>, you must specify the [CHAIN_MSG_MAP_DYNAMIC](../vs140/chain_msg_map_dynamic.md) macro in your message map. For an example, see the [CDynamicChain](../vs140/cdynamicchain-class.md) overview.  
  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> requires a previous call to [SetChainEntry](../vs140/cdynamicchain--setchainentry.md) to associate the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> value with an object and its message map.  
  
## Requirements  
 **Header:** atlwin.h  
  
## See Also  
 [CDynamicChain Class](../vs140/cdynamicchain-class.md)