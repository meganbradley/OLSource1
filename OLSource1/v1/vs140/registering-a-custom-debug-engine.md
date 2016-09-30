---
title: "Registering a Custom Debug Engine"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: na
ms.topic: "article"
helpviewer_keywords: 
  - "debug engines, registering"
ms.assetid: 9984cd3d-d34f-4662-9ace-31766499abf5
caps.latest.revision: 10
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# Registering a Custom Debug Engine
The debug engine must register itself as a class factory following COM conventions as well as register with Visual Studio through the Visual Studio registry subkey.  
  
> [!NOTE]
>  An example of how to register a debug engine can be found in the TextInterpreter sample, which is built as part of the [Tutorial: Building a Debug Engine Using ATL COM](assetId:///9097b71e-1fe7-48f7-bc00-009e25940c24).  
  
## DLL Server process  
 Typically, a debug engine is implemented in its own DLL as a COM server. This means that the debug engine must register the CLSID of its class factory with COM before Visual Studio can access it. Then the debug engine must register itself with Visual Studio itself in order to establish any properties (otherwise known as metrics) the debug engine supports. The choice of metrics that are written to the Visual Studio registry subkey for the debug engine depends on the features the debug engine supports.  
  
 [Debugging SDK Helpers](../vs140/sdk-helpers-for-debugging.md) describes not only the registry locations necessary to register a debug engine; it also describes the dbgmetric.lib library, which contains a number of useful functions and declarations for C++ developers that make manipulating the registry easier.  
  
### Example  
 The following is a typical example (from the TextInterpreter sample) showing how to use the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> function (from dbgmetric.lib), to register a debug engine with Visual Studio. The metrics being passed are also defined in dbgmetric.lib.  
  
> [!NOTE]
>  TextInterpreter is a basic debug engine; it does not implement—and therefore does not register—any other features. A more complete debug engine would have a whole list of <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> calls or their equivalent, one for each feature the debug engine supports.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## See Also  
 [Creating a Custom Debug Engine](../vs140/creating-a-custom-debug-engine.md)   
 [Debugging SDK Helpers](../vs140/sdk-helpers-for-debugging.md)   
 [Tutorial: Building a Debug Engine Using ATL COM](assetId:///9097b71e-1fe7-48f7-bc00-009e25940c24)