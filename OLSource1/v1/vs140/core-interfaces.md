---
title: "Core Interfaces"
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
  - "debugging [Debugging SDK], core interfaces"
ms.assetid: 666b9116-8550-4bdd-bc15-55fc57de87df
caps.latest.revision: 28
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# Core Interfaces
The following interfaces are the core interfaces for extending debugger by using the [!INCLUDE[vsipsdk](../vs140/includes/vsipsdk_md.md)].  
  
## Discussion  
 These interfaces are primarily used to create the debug engine (DE). They are organized here by categories:  
  
-   [Breakpoints](#Breakpoints)  
  
-   [Contexts](#Contexts)  
  
-   [Core Server](#CoreServer)  
  
-   [Debug Engines](#DebugEngines)  
  
-   [Documents](#Documents)  
  
-   [Events](#Events)  
  
-   [Expressions](#Expressions)  
  
-   [Memory](#Memory)  
  
-   [Modules](#Modules)  
  
-   [Ports](#Ports)  
  
-   [Processes](#Processes)  
  
-   [Programs](#Programs)  
  
-   [Properties](#Properties)  
  
-   [Stack Frames](#StackFrames)  
  
-   [Threads](#Threads)  
  
-   [Type Visualizers](#TypeVisualizers)  
  
 The entities that can implement the interfaces are:  
  
-   Debug Engine (DE)  
  
-   Port Supplier (PS)  
  
-   Expression Evaluator (EE)  
  
-   Visual Studio (VS)  
  
##  \<a name="Breakpoints">\</a> Breakpoints  
 These interfaces are related to the implementation and tracking of breakpoints.  
  
|Interface|Implemented by|Description|  
|---------------|--------------------|-----------------|  
|[IDebugBoundBreakpoint2](../vs140/idebugboundbreakpoint2.md)|DE|Represents a breakpoint bound to a memory location.|  
|[IDebugBreakpointBoundEvent2](../vs140/idebugbreakpointboundevent2.md)|DE|Sent by the DE when a breakpoint is bound to a memory location.|  
|[IDebugBreakpointChecksumRequest2](../vs140/idebugbreakpointchecksumrequest2.md)|VS|Represents a document checksum for a breakpoint request.|  
|[IDebugBreakpointErrorEvent2](../vs140/idebugbreakpointerrorevent2.md)|DE|Sent by the DE when a breakpoint fails to be bound to a memory location.|  
|[IDebugBreakpointEvent2](../vs140/idebugbreakpointevent2.md)|DE|Sent by the DE when a breakpoint is reached.|  
|[IDebugBreakpointRequest2](../vs140/idebugbreakpointrequest2.md)|VS|Represents a request for a breakpoint; used in creating a pending breakpoint.|  
|[IDebugBreakpointRequest3](../vs140/idebugbreakpointrequest3.md)|VS|Represents a request for a breakpoint; used in creating a pending breakpoint.|  
|[IDebugBreakpointResolution2](../vs140/idebugbreakpointresolution2.md)|DE|Represents the information used to bind a breakpoint.|  
|[IDebugBreakpointUnboundEvent2](../vs140/idebugbreakpointunboundevent2.md)|DE|Sent by the DE when a breakpoint is unbound from a memory location.|  
|[IDebugErrorBreakpoint2](../vs140/idebugerrorbreakpoint2.md)|DE|Represents an invalid breakpoint (returned by <CodeContentPlaceHolder>0\</CodeContentPlaceHolder>).|  
|[IDebugErrorBreakpointResolution2](../vs140/idebugerrorbreakpointresolution2.md)|DE|Represents the resolution information about an invalid breakpoint.|  
|[IDebugFunctionPosition2](../vs140/idebugfunctionposition2.md)|DE|Represents a position in a function where a breakpoint is set.|  
|[IDebugPendingBreakpoint2](../vs140/idebugpendingbreakpoint2.md)|DE|Represents a breakpoint that is to be bound; used in creating a bound breakpoint.|  
|[IEnumDebugBoundBreakpoints2](../vs140/ienumdebugboundbreakpoints2.md)|DE|Represents an enumeration over a set of bound breakpoints.|  
|[IEnumDebugErrorBreakpoints2](../vs140/ienumdebugerrorbreakpoints2.md)|DE|Represents an enumeration over a set of breakpoints that could not be bound to a memory location.|  
  
##  \<a name="Contexts">\</a> Contexts  
 These interfaces represent various kinds of contexts within the program being debugged.  
  
|Interface|Implemented by|Description|  
|---------------|--------------------|-----------------|  
|[IDebugCodeContext2](../vs140/idebugcodecontext2.md)|DE|Represents the starting position of a code instruction.|  
|[IDebugCodeContext3](../vs140/idebugcodecontext3.md)|DE|Extends the [IDebugCodeContext2](../vs140/idebugcodecontext2.md) interface to enable the retrieval of module and process interfaces.|  
|[IDebugDocumentContext2](../vs140/idebugdocumentcontext2.md)|VS, DE|Represents a position in a document.|  
|[IDebugExpressionContext2](../vs140/idebugexpressioncontext2.md)|DE|Represents the context in which to evaluate an expression.|  
|[IDebugMemoryContext2](../vs140/idebugmemorycontext2.md)|DE|Represents the starting location in memory of a collection of bytes.|  
|[IDebugStackFrame2](../vs140/idebugstackframe2.md)|DE|Represents a stack frame context at a breakpoint or exception.|  
|[IDebugStackFrame3](../vs140/idebugstackframe3.md)|DE|Represents a stack frame context at a breakpoint or exception.|  
|[IEnumDebugCodeContexts2](../vs140/ienumdebugcodecontexts2.md)|DE|Represents an enumeration over a set of code contexts.|  
  
##  \<a name="CoreServer">\</a> Core Server  
 These interfaces represent the machine on which a program is being debugged. These are implemented by [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] but can be called into by debug engines.  
  
|Interface|Implemented by|Description|  
|---------------|--------------------|-----------------|  
|[IDebugCoreServer2](../vs140/idebugcoreserver2.md)|VS|Provides access to ports and port suppliers as well as information about the computer.|  
|[IDebugCoreServer3](../vs140/idebugcoreserver3.md)|VS|Represents an [IDebugCoreServer2](../vs140/idebugcoreserver2.md) that supports remote debugging.|  
  
##  \<a name="DebugEngines">\</a> Debug Engines  
 These interfaces represent debug engines and their associated events.  
  
|Interface|Implemented by|Description|  
|---------------|--------------------|-----------------|  
|[IDebugEngine2](../vs140/idebugengine2.md)|DE|Represents a custom debug engine.|  
|[IDebugEngine3](../vs140/idebugengine3.md)|DE|Represents a custom debug engine that supports loading of symbols, JustMyCode, and exceptions.|  
|[IDebugEngineCreateEvent2](../vs140/idebugenginecreateevent2.md)|DE|Sent by each new instance of the DE to indicate it is ready to handle debugging tasks.|  
|[IDebugEngineLaunch2](../vs140/idebugenginelaunch2.md)|DE|Represents a custom debug engine that supports launching programs.|  
|[IDebugProgramEngines2](../vs140/idebugprogramengines2.md)|DE, PS|Represents a program node that handles multiple debug engines.|  
|[IDebugQueryEngine2](../vs140/idebugqueryengine2.md)|DE|Provides a way for the SDM to obtain an interface to the debug engine from a thread, program, or stack frame.|  
  
##  \<a name="Documents">\</a> Documents  
 These interfaces represent documents (source files) and their associated elements.  
  
|Interface|Implemented by|Description|  
|---------------|--------------------|-----------------|  
|[IDebugActivateDocumentEvent2](../vs140/idebugactivatedocumentevent2.md)|DE|Sent by the DE to request a document to be opened.|  
|[IDebugDisassemblyStream2](../vs140/idebugdisassemblystream2.md)|DE|Represents a stream of disassembled instructions from a document.|  
|[IDebugDocument2](../vs140/idebugdocument2.md)|VS, DE|Represents a document supplied by the DE, specifying a name and a class ID (CLSID).|  
|[IDebugDocumentChecksum2](../vs140/idebugdocumentchecksum2.md)|DE, EE|Represents a checksum for a debug document and enables passing the checksum between components.|  
|[IDebugDocumentContext2](../vs140/idebugdocumentcontext2.md)|VS, DE|Represents a document context, a position within a document corresponding to a particular statement and code context.|  
|[IDebugDocumentPosition2](../vs140/idebugdocumentposition2.md)|VS, DE|Represents a general position within a document.|  
|[IDebugDocumentPositionOffset2](../vs140/idebugdocumentpositionoffset2.md)|VS|Represents a position in a source file as a character offset.|  
|[IDebugDocumentText2](../vs140/idebugdocumenttext2.md)|VS, DE|Represents a text document supplied by the DE (derived from [IDebugDocument2](../vs140/idebugdocument2.md)), supplying the actual text.|  
|[IDebugDocumentTextEvents2](../vs140/idebugdocumenttextevents2.md)|DE|Sent by the DE to specify changes to a source file that is in memory.|  
  
##  \<a name="Events">\</a> Events  
 These interfaces represent all events that are sent between the DE and the session debug manager (SDM).  
  
|Interface|Implemented by|Description|  
|---------------|--------------------|-----------------|  
|[IDebugActivateDocumentEvent2](../vs140/idebugactivatedocumentevent2.md)|DE|Sent by the DE to request a document to be opened.|  
|[IDebugBeforeSymbolSearchEvent2](../vs140/idebugbeforesymbolsearchevent2.md)|DE|The debug engine (DE) sends this interface to the session debug manager (SDM) to set the status bar message during symbol loads.|  
|[IDebugBreakEvent2](../vs140/idebugbreakevent2.md)|DE|Sent by the DE when a break in the program has been completed.|  
|[IDebugBreakpointBoundEvent2](../vs140/idebugbreakpointboundevent2.md)|DE|Sent by the DE when a breakpoint is bound.|  
|[IDebugBreakpointErrorEvent2](../vs140/idebugbreakpointerrorevent2.md)|DE|Sent by the DE when a breakpoint fails to be bound.|  
|[IDebugBreakpointEvent2](../vs140/idebugbreakpointevent2.md)|DE|Sent by the DE when a breakpoint is reached.|  
|[IDebugBreakpointUnboundEvent2](../vs140/idebugbreakpointunboundevent2.md)|DE|Sent by the DE when a breakpoint is unbound.|  
|[IDebugCanStopEvent2](../vs140/idebugcanstopevent2.md)|DE|Sent by the DE to determine whether it should stop at a particular location.|  
|[IDebugDocumentTextEvents2](../vs140/idebugdocumenttextevents2.md)|DE|Sent by the DE to specify changes to a source file that is in memory.|  
|[IDebugEngineCreateEvent2](../vs140/idebugenginecreateevent2.md)|DE|Sent by each new instance of the DE to indicate it is ready to handle debugging tasks.|  
|[IDebugEntryPointEvent2](../vs140/idebugentrypointevent2.md)|DE|Sent by the DE to indicate the program being debugged is ready to execute the first instruction.|  
|[IDebugErrorEvent2](../vs140/idebugerrorevent2.md)|DE|An interface that is used by other event interfaces, which might return an error, to provide human-readable error messages.|  
|[IDebugEvent2](../vs140/idebugevent2.md)|DE, PS|Base interface from which all other event interfaces are derived.|  
|[IDebugEventCallback2](../vs140/idebugeventcallback2.md)|VS|Represents an interface implemented by the SDM to which events (expressed as objects implementing a particular event interface) are sent.|  
|[IDebugExceptionEvent2](../vs140/idebugexceptionevent2.md)|DE|Sent by the DE when an exception has occurred in the program being debugged.|  
|[IDebugExpressionEvaluationCompleteEvent2](../vs140/idebugexpressionevaluationcompleteevent2.md)|DE|Sent by the DE when an asynchronous expression evaluation is complete.|  
|IDebugFindSymbolEvent2||OBSOLETE. DO NOT USE.|  
|[IDebugInterceptExceptionCompleteEvent2](../vs140/idebuginterceptexceptioncompleteevent2.md)|DE|Sent by the DE when processing for an intercepted exception has been completed.|  
|[IDebugLoadCompleteEvent2](../vs140/idebugloadcompleteevent2.md)|DE|Sent by the DE when a program has completed loading.|  
|[IDebugMessageEvent2](../vs140/idebugmessageevent2.md)|DE|Sent by the DE to have the IDE display an informational message to the user.|  
|[IDebugModuleLoadEvent2](../vs140/idebugmoduleloadevent2.md)|DE|Sent by the DE when a module is loaded or unloaded.|  
|[IDebugNoSymbolsEvent2](../vs140/idebugnosymbolsevent2.md)|DE|Signals the [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] debugger UI to warn the user that symbols could not be located for the launched executable.|  
|[IDebugOutputStringEvent2](../vs140/idebugoutputstringevent2.md)|DE|Sent by the DE to have the IDE display an arbitrary string.|  
|[IDebugPortEvents2](../vs140/idebugportevents2.md)|VS, DE|Sent by a port to communicate port events to any listener.|  
|[IDebugProcessCreateEvent2](../vs140/idebugprocesscreateevent2.md)|DE, PS|Sent by the DE or port when a process has been created.|  
|[IDebugProcessDestroyEvent2](../vs140/idebugprocessdestroyevent2.md)|DE, PS|Sent by the DE or port when a process has been destroyed.|  
|[IDebugProgramCreateEvent2](../vs140/idebugprogramcreateevent2.md)|DE, PS|Sent by the DE or port when a program has been created.|  
|[IDebugProgramDestroyEvent2](../vs140/idebugprogramdestroyevent2.md)|DE, PS|Sent by the DE or port when a program has been destroyed.|  
|[IDebugProgramDestroyEventFlags2](../vs140/idebugprogramdestroyeventflags2.md)|DE|Enables a debug engine to override the default behavior of the [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] UI when you end a debug session.|  
|[IDebugProgramNameChangedEvent2](../vs140/idebugprogramnamechangedevent2.md)|DE|Sent from the debug engine (DE) to the session debug manager (SDM) when the name of a program changes.|  
|[IDebugPropertyCreateEvent2](../vs140/idebugpropertycreateevent2.md)|DE|Sent by the DE when a new property (represented by the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> interface) has been created.|  
|[IDebugPropertyDestroyEvent2](../vs140/idebugpropertydestroyevent2.md)|DE|Sent by the DE when a property has been destroyed.|  
|[IDebugReturnValueEvent2](../vs140/idebugreturnvalueevent2.md)|DE|Sent by the DE when stepping out of or over a function so the return value can be correctly displayed.|  
|[IDebugSettingsCallback2](../vs140/idebugsettingscallback2.md)|VS|Enables debug engines to read metric settings remotely.|  
|[IDebugStepCompleteEvent2](../vs140/idebugstepcompleteevent2.md)|DE|Sent by the DE when a step into, over, or out of an instruction has been completed.|  
|[IDebugSymbolSearchEvent2](../vs140/idebugsymbolsearchevent2.md)|DE|Sent by the DE to indicate the success or failure of loading symbols for a module.|  
|[IDebugThreadCreateEvent2](../vs140/idebugthreadcreateevent2.md)|DE|Sent by the DE when a thread has been created.|  
|[IDebugThreadDestroyEvent2](../vs140/idebugthreaddestroyevent2.md)|DE|Sent by the DE when a thread has been destroyed.|  
|[IDebugThreadNameChangedEvent2](../vs140/idebugthreadnamechangedevent2.md)|DE|Sent by the DE when a thread has changed its name.|  
  
##  \<a name="Expressions">\</a> Expressions  
 These interfaces represent expressions to be evaluated in a particular context.  
  
|Interface|Implemented by|Description|  
|---------------|--------------------|-----------------|  
|[IDebugExpression2](../vs140/idebugexpression2.md)|DE|Represents an expression to be evaluated. Obtained from the [IDebugExpressionContext2](../vs140/idebugexpressioncontext2.md) interface.|  
|[IDebugExpressionContext2](../vs140/idebugexpressioncontext2.md)|DE|Represents a context in which an expression is evaluated. Obtained from the [IDebugStackFrame2](../vs140/idebugstackframe2.md) interface.|  
|[IDebugExpressionEvaluationCompleteEvent2](../vs140/idebugexpressionevaluationcompleteevent2.md)|DE|Sent by the DE when an asynchronous expression evaluation is complete.|  
  
##  \<a name="Memory">\</a> Memory  
 These interfaces represent sequences of bytes in memory.  
  
|Interface|Implemented by|Description|  
|---------------|--------------------|-----------------|  
|[IDebugMemoryBytes2](../vs140/idebugmemorybytes2.md)|DE|Represents a sequence of bytes in memory that can be read from or written to.|  
|[IDebugMemoryContext2](../vs140/idebugmemorycontext2.md)|DE|Represents a location in memory of a sequence of bytes.|  
  
##  \<a name="Modules">\</a> Modules  
 These interfaces represent a module, which corresponds to an executable or .DLL file.  
  
|Interface|Implemented by|Description|  
|---------------|--------------------|-----------------|  
|[IDebugModule2](../vs140/idebugmodule2.md)|DE|Represents a single executable or DLL.|  
|[IDebugModule3](../vs140/idebugmodule3.md)|DE|Represents an [IDebugModule2](../vs140/idebugmodule2.md) that supports symbols.|  
|[IDebugModuleLoadEvent2](../vs140/idebugmoduleloadevent2.md)|DE|Sent by the DE when a module is loaded or unloaded.|  
|[IDebugSourceServerModule](../vs140/idebugsourceservermodule.md)|DE|Represents the source server information that is contained in a PDB file.|  
|[IEnumDebugModules2](../vs140/ienumdebugmodules2.md)|DE|Represents an enumeration over a set of modules that are known by an [IDebugProgram2](../vs140/idebugprogram2.md).|  
  
##  \<a name="Ports">\</a> Ports  
 These interfaces represent ports and port suppliers.  
  
|Interface|Implemented by|Description|  
|---------------|--------------------|-----------------|  
|[IDebugDefaultPort2](../vs140/idebugdefaultport2.md)|VS, PS|Represents the default port on the local computer.|  
|[IDebugFirewallConfigurationCallback2](../vs140/idebugfirewallconfigurationcallback2.md)|VS|Enables a debug engine that uses DCOM to ask the [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] UI to make sure that the firewall will not block remote debugging.|  
|[IDebugPort2](../vs140/idebugport2.md)|VS, PS|Represents a port.|  
|[IDebugPortEvents2](../vs140/idebugportevents2.md)|PS|Sent by a port to communicate port events to any listener.|  
|[IDebugPortEx2](../vs140/idebugportex2.md)|PS|Represents a port that can launch and terminate processes.|  
|[IDebugPortNotify2](../vs140/idebugportnotify2.md)|PS|Used to register and unregister programs with a port; allows the port to track programs currently being debugged.|  
|[IDebugPortPicker](../vs140/idebugportpicker.md)|PS|Represents a customized UI for selecting the port.|  
|[IDebugPortRequest2](../vs140/idebugportrequest2.md)|VS|Represents a request for a port from which a new port will be created or located.|  
|[IDebugPortSupplier2](../vs140/idebugportsupplier2.md)|PS|Represents a supplier of ports.|  
|[IDebugPortSupplier3](../vs140/idebugportsupplier3.md)|PS|Represents a supplier of ports that can persist (save to disk) information about the ports it created.|  
|[IDebugPortSupplierDescription2](../vs140/idebugportsupplierdescription2.md)|PS|Enables the [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] UI to display text inside the **Transport Information** section of the **Attach to Process** dialog box.|  
|[IDebugWindowsComputerPort2](../vs140/idebugwindowscomputerport2.md)|VS|Allows querying for information about the target computer.|  
|[IEnumDebugPorts2](../vs140/ienumdebugports2.md)|VS, PS|Represents an enumeration over a set of ports.|  
|[IEnumDebugPortSuppliers2](../vs140/ienumdebugportsuppliers2.md)|VS|Represents an enumeration over a set of port suppliers.|  
  
##  \<a name="Processes">\</a> Processes  
 These interfaces represent processes, a single executable that contains one or more programs.  
  
|Interface|Implemented by|Description|  
|---------------|--------------------|-----------------|  
|[IDebugProcess2](../vs140/idebugprocess2.md)|PS, DE|Represents a process that is running on a computer.|  
|[IDebugProcess3](../vs140/idebugprocess3.md)|PS, DE|Represents a process that actively supports debugging (used to replace Step, Continue, and Execute methods on the [IDebugProgram2](../vs140/idebugprogram2.md) interface).|  
|[IDebugProcessCreateEvent2](../vs140/idebugprocesscreateevent2.md)|DE, PS|Sent by the DE or port when a process has been created.|  
|[IDebugProcessDestroyEvent2](../vs140/idebugprocessdestroyevent2.md)|DE, PS|Sent by the DE or port when a process has been destroyed.|  
|[IDebugProcessEx2](../vs140/idebugprocessex2.md)|PS|Represents a process that must track which session is attached to it.|  
|[IEnumDebugProcesses2](../vs140/ienumdebugprocesses2.md)|PS|Represents an enumeration of a set of processes on a port.|  
  
##  \<a name="Programs">\</a> Programs  
 These interfaces represent programs, logical units of execution that do not necessarily correspond to a physical executable or module.  
  
|Interface|Implemented by|Description|  
|---------------|--------------------|-----------------|  
|[IDebugEngineProgram2](../vs140/idebugengineprogram2.md)|DE|Represents an [IDebugProgram2](../vs140/idebugprogram2.md) that needs to work in concert with other programs being debugged at the same time.|  
|[IDebugProgram2](../vs140/idebugprogram2.md)|DE, PS|Represents a logical unit of execution.|  
|[IDebugProgramCreateEvent2](../vs140/idebugprogramcreateevent2.md)|DE, PS|Sent by the DE or port when a program has been created.|  
|[IDebugProgramDestroyEvent2](../vs140/idebugprogramdestroyevent2.md)|DE, PS|Sent by the DE or port when a program has been destroyed.|  
|[IDebugProgramEngines2](../vs140/idebugprogramengines2.md)|DE, PS|Represents an [IDebugProgramNode2](../vs140/idebugprogramnode2.md) that can be handled by multiple debug engines.|  
|[IDebugProgramEx2](../vs140/idebugprogramex2.md)|PS|Represents an [IDebugProgram2](../vs140/idebugprogram2.md) that must be able to track which session is attached to it.|  
|[IDebugProgramHost2](../vs140/idebugprogramhost2.md)|DE, PS|Represents an [IDebugProgram2](../vs140/idebugprogram2.md) that can return information about the process in which it is running.|  
|[IDebugProgramNode2](../vs140/idebugprogramnode2.md)|DE, PS|Represents a program that can be debugged.|  
|[IDebugProgramNodeAttach2](../vs140/idebugprogramnodeattach2.md)|DE, PS|Allows a program node to be notified of an attempt to attach to the associated program.|  
|[IDebugProgramProvider2](../vs140/idebugprogramprovider2.md)|DE|Provides a way for the SDM to query a DE about the programs controlled by that DE.|  
|[IDebugProgramPublisher2](../vs140/idebugprogrampublisher2.md)|VS|Used by DEs to register programs with the SDM to show they are being debugged.|  
|[IDebugProviderProgramNode2](../vs140/idebugproviderprogramnode2.md)|DE, PS|Represents an [IDebugProgramNode2](../vs140/idebugprogramnode2.md) that can marshal interfaces across thread or process boundaries.|  
|[IEnumDebugPrograms2](../vs140/ienumdebugprograms2.md)|DE, PS|Represents an enumeration of a set of programs.|  
  
##  \<a name="Properties">\</a> Properties  
 These interfaces represent properties, a value associated with a particular context, usually the result of an expression evaluation.  
  
|Interface|Implemented by|Description|  
|---------------|--------------------|-----------------|  
|[IDebugCustomViewer](../vs140/idebugcustomviewer.md)|EE|Represents an [IDebugProperty2](../vs140/idebugproperty2.md) that can display its value in a custom way.|  
|[IDebugProperty2](../vs140/idebugproperty2.md)|DE|Represents a value of a stack frame, document, or the result of an expression evaluation.|  
|[IDebugProperty3](../vs140/idebugproperty3.md)|DE|Represents an [IDebugProperty2](../vs140/idebugproperty2.md) that supports arbitrarily long strings.|  
|[IDebugPropertyCreateEvent2](../vs140/idebugpropertycreateevent2.md)|DE|Sent by the DE when a new property (represented by the [IDebugProperty2](../vs140/idebugproperty2.md) interface) has been created.|  
|[IDebugPropertyDestroyEvent2](../vs140/idebugpropertydestroyevent2.md)|DE|Sent by the DE when a property has been destroyed.|  
|[IDebugReference2](../vs140/idebugreference2.md)|DE|Represents a reference to a property which can exist outside any particular stack frame.|  
|[IEnumDebugPropertyInfo2](../vs140/ienumdebugpropertyinfo2.md)|DE|Represents an enumeration over a set of [DEBUG_PROPERTY_INFO](../vs140/debug_property_info.md) structures which describe variables, registers, parameters, and expressions.|  
|[IEnumDebugReferenceInfo2](../vs140/ienumdebugreferenceinfo2.md)|DE|Represents an enumeration over a set of [DEBUG_REFERENCE_INFO](../vs140/debug_reference_info.md) structures.|  
  
##  \<a name="StackFrames">\</a> Stack Frames  
 These interfaces represent a stack frame, a context in which a breakpoint or exception has occurred.  
  
|Interface|Implemented by|Description|  
|---------------|--------------------|-----------------|  
|[IDebugStackFrame2](../vs140/idebugstackframe2.md)|DE|Represents a context in which a breakpoint or exception has occurred.|  
|[IDebugStackFrame3](../vs140/idebugstackframe3.md)|DE|Represents an [IDebugStackFrame2](../vs140/idebugstackframe2.md) which can handle intercepted exceptions.|  
|[IEnumCodePaths2](../vs140/ienumcodepaths2.md)|DE|Represents an enumeration over the set of [CODE_PATH](../vs140/code_path.md) structures which specify the function call sequence used to arrive at a particular stack frame.|  
|[IEnumDebugFrameInfo2](../vs140/ienumdebugframeinfo2.md)|DE|Represents an enumeration over a set of [FRAMEINFO](../vs140/frameinfo.md) structures, which describe stack frames.|  
  
##  \<a name="Threads">\</a> Threads  
 These interfaces represent threads and their associated events.  
  
|Interface|Implemented by|Description|  
|---------------|--------------------|-----------------|  
|[IDebugThread2](../vs140/idebugthread2.md)|DE|Represents a thread of execution.|  
|[IDebugThreadCreateEvent2](../vs140/idebugthreadcreateevent2.md)|DE|Sent by the DE when a thread has been created.|  
|[IDebugThreadDestroyEvent2](../vs140/idebugthreaddestroyevent2.md)|DE|Sent by the DE when a thread has been destroyed.|  
|[IDebugThreadNameChangedEvent2](../vs140/idebugthreadnamechangedevent2.md)|DE|Sent by the DE when a thread has changed its name.|  
|[IEnumDebugThreads2](../vs140/ienumdebugthreads2.md)|DE|Represents an enumeration over a set of threads.|  
  
##  \<a name="TypeVisualizers">\</a> Type Visualizers  
 These interfaces provide support for type visualizers. These interfaces are typically implemented by an expression evaluator.  
  
|Interface|Implemented by|Description|  
|---------------|--------------------|-----------------|  
|[IEEDataStorage](../vs140/ieedatastorage.md)|EE|Represents an array of bytes to be presented to a type visualizer.|  
|[IPropertyProxyEESide](../vs140/ipropertyproxyeeside.md)|EE|Provides methods for getting access to data to be passed to a type visualizer.|  
|[IPropertyProxyProvider](../vs140/ipropertyproxyprovider.md)|EE|Represents a  property that provides access to [IPropertyProxyEESide](../vs140/ipropertyproxyeeside.md) implementations.|  
  
## See Also  
 [API Reference](../vs140/api-reference--visual-studio-debugging-.md)   
 [Creating a Custom Debug Engine](../vs140/creating-a-custom-debug-engine.md)