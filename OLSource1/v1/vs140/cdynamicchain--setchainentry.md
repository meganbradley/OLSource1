---
title: "CDynamicChain::SetChainEntry"
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
  - "CDynamicChain::SetChainEntry"
  - "ATL.CDynamicChain.SetChainEntry"
  - "CDynamicChain.SetChainEntry"
  - "SetChainEntry"
  - "ATL::CDynamicChain::SetChainEntry"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetChainEntry method"
ms.assetid: 712bde44-ee9b-4990-8bbf-3add4c47a9f0
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDynamicChain::SetChainEntry
Adds the specified message map to the collection.  
  
## Syntax  
  
```  
  
      BOOL SetChainEntry(  
   DWORD dwChainID,  
   CMessageMap* pObject,  
   DWORD dwMsgMapID = 0   
);  
```  
  
#### Parameters  
 `dwChainID`  
 [in] The unique identifier associated with the chained object and its message map.  
  
 `pObject`  
 [in] A pointer to the chained object declaring the message map. This object must derive from [CMessageMap](../vs140/cmessagemap-class.md).  
  
 `dwMsgMapID`  
 [in] The identifier of the message map in the chained object. The default value is 0, which identifies the default message map declared with [BEGIN_MSG_MAP](../vs140/begin_msg_map.md). To specify an alternate message map declared with [ALT_MSG_MAP(msgMapID)](../vs140/alt_msg_map.md), pass `msgMapID`.  
  
## Return Value  
 **TRUE** if the message map is successfully added to the collection. Otherwise, **FALSE**.  
  
## Remarks  
 If the `dwChainID` value already exists in the collection, its associated object and message map are replaced by `pObject` and `dwMsgMapID`, respectively. Otherwise, a new entry is added.  
  
## Requirements  
 **Header:** atlwin.h  
  
## See Also  
 [CDynamicChain Class](../vs140/cdynamicchain-class.md)   
 [CDynamicChain::CallChain](../vs140/cdynamicchain--callchain.md)   
 [CDynamicChain::RemoveChainEntry](../vs140/cdynamicchain--removechainentry.md)   
 [CHAIN_MSG_MAP_DYNAMIC](../vs140/chain_msg_map_dynamic.md)