---
title: "IDebugPortEvents2::Event"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "IDebugPortEvents2::Event"
helpviewer_keywords: 
  - "IDebugPortEvents2::Event"
ms.assetid: 5cc813f7-04a1-4462-9ea7-fbddcf0e0143
caps.latest.revision: 22
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IDebugPortEvents2::Event
This method sends events that signify the creation and destruction of processes and programs on a port.  
  
## Syntax  
  
```cpp#  
HRESULT Event(  
   IDebugCoreServer2* pServer,  
   IDebugPort2*       pPort,  
   IDebugProcess2*    pProcess,  
   IDebugProgram2*    pProgram,  
   IDebugEvent2*      pEvent,  
   REFIID             riidEvent  
);  
```  
  
```c#  
int Event(  
   IDebugCoreServer2 pServer,   
   IDebugPort2       pPort,   
   IDebugProcess2    pProcess,   
   IDebugProgram2    pProgram,   
   IDebugEvent2      pEvent,   
   ref Guid          riidEvent  
);  
```  
  
#### Parameters  
 `pMachine`  
 [in] An [IDebugCoreServer2](../vs140/idebugcoreserver2.md) object that represents the debug server (there is one for every instance of [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)]) in which the event occurred.  
  
 `pPort`  
 [in] An [IDebugPort2](../vs140/idebugport2.md) object that represents the port in which the event occurred.  
  
 `pProcess`  
 [in] An [IDebugProcess2](../vs140/idebugprocess2.md) object that represents the process in which the event occurred.  
  
 `pProgram`  
 [in] An [IDebugProgram2](../vs140/idebugprogram2.md) object that represents the program in which the event occurred.  
  
 `pEvent`  
 [in] An [IDebugEvent2](../vs140/idebugevent2.md) object that identifies the event. The possible events are as follows:  
  
-   [IDebugProcessCreateEvent2](../vs140/idebugprocesscreateevent2.md)  
  
-   [IDebugProcessDestroyEvent2](../vs140/idebugprocessdestroyevent2.md)  
  
-   [IDebugProgramCreateEvent2](../vs140/idebugprogramcreateevent2.md)  
  
-   [IDebugProgramDestroyEvent2](../vs140/idebugprogramdestroyevent2.md)  
  
 `riidEvent`  
 [in] The GUID of the event. Because the event is cast to [IDebugEvent2](../vs140/idebugevent2.md) before calling this method, this identifier makes it easier to determine which event is being sent.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## See Also  
 [IDebugPortEvents2](../vs140/idebugportevents2.md)   
 [IDebugCoreServer2](../vs140/idebugcoreserver2.md)   
 [IDebugPort2](../vs140/idebugport2.md)   
 [IDebugProcess2](../vs140/idebugprocess2.md)   
 [IDebugProgram2](../vs140/idebugprogram2.md)   
 [IDebugEvent2](../vs140/idebugevent2.md)