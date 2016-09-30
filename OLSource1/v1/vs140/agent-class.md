---
title: "agent Class"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "agents/concurrency::agent"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "agent class"
ms.assetid: 1b09e3d2-5e37-4966-b016-907ef1512456
caps.latest.revision: 21
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# agent Class
A class intended to be used as a base class for all independent agents. It is used to hide state from other agents and interact using message-passing.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[agent::agent Constructor](#agent__agent_constructor)|Overloaded. Constructs an agent.|  
|[agent::~agent Destructor](#agent___dtoragent_destructor)|Destroys the agent.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[agent::cancel Method](#agent__cancel_method)|Moves an agent from either the                                         <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> or                                         <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> states to the                                         <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> state.|  
|[agent::start Method](#agent__start_method)|Moves an agent from the                                         <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> state to the                                         <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> state, and schedules it for execution.|  
|[agent::status Method](#agent__status_method)|A synchronous source of status information from the agent.|  
|[agent::status_port Method](#agent__status_port_method)|An asynchronous source of status information from the agent.|  
|[agent::wait Method](#agent__wait_method)|Waits for an agent to complete its task.|  
|[agent::wait_for_all Method](#agent__wait_for_all_method)|Waits for all of the specified agents to complete their tasks.|  
|[agent::wait_for_one Method](#agent__wait_for_one_method)|Waits for any one of the specified agents to complete its task.|  
  
### Protected Methods  
  
|Name|Description|  
|----------|-----------------|  
|[agent::done Method](#agent__done_method)|Moves an agent into the                                         <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> state, indicating that the agent has completed.|  
|[agent::run Method](#agent__run_method)|Represents the main task of an agent.                                         <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> should be overridden in a derived class, and specifies what the agent should do after it has been started.|  
  
## Remarks  
 For more information, see                 [Asynchronous Agents](../vs140/asynchronous-agents.md).  
  
## Inheritance Hierarchy  
 <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
  
## Requirements  
 **Header:** agents.h  
  
 **Namespace:** concurrency  
  
##  \<a name="agent__agent_constructor">\</a>  agent::agent Constructor  
 Constructs an agent.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>  
 The                                 <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> object within which the execution task of the agent is scheduled.  
  
 <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>  
 The                                 <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> object within which the execution task of the agent is scheduled. The                                 <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> object used is implied by the schedule group.  
  
### Remarks  
 The runtime uses the default scheduler if you do not specify the                         <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> or                         <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> parameters.  
  
##  \<a name="agent___dtoragent_destructor">\</a>  agent::~agent Destructor  
 Destroys the agent.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Remarks  
 It is an error to destroy an agent that is not in a terminal state (either                         <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> or                         <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>). This can be avoided by waiting for the agent to reach a terminal state in the destructor of a class that inherits from the                         <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> class.  
  
##  \<a name="agent__cancel_method">\</a>  agent::cancel Method  
 Moves an agent from either the                 <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> or                 <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> states to the                 <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> state.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Return Value  
 <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> if the agent was canceled,                         <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> otherwise. An agent cannot be canceled if it has already started running or has already completed.  
  
##  \<a name="agent__done_method">\</a>  agent::done Method  
 Moves an agent into the                 <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> state, indicating that the agent has completed.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Return Value  
 <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> if the agent is moved to the                         <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> state,                         <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> otherwise. An agent that has been canceled cannot be moved to the                         <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> state.  
  
### Remarks  
 This method should be called at the end of the                         <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> method, when you know the execution of your agent has completed.  
  
##  \<a name="agent__run_method">\</a>  agent::run Method  
 Represents the main task of an agent.                 <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> should be overridden in a derived class, and specifies what the agent should do after it has been started.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Remarks  
 The agent status is changed to                         <CodeContentPlaceHolder>42\</CodeContentPlaceHolder> right before this method is invoked. The method should invoke                         <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> on the agent with an appropriate status before returning, and may not throw any exceptions.  
  
##  \<a name="agent__start_method">\</a>  agent::start Method  
 Moves an agent from the                 <CodeContentPlaceHolder>44\</CodeContentPlaceHolder> state to the                 <CodeContentPlaceHolder>45\</CodeContentPlaceHolder> state, and schedules it for execution.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Return Value  
 <CodeContentPlaceHolder>46\</CodeContentPlaceHolder> if the agent started correctly,                         <CodeContentPlaceHolder>47\</CodeContentPlaceHolder> otherwise. An agent that has been canceled cannot be started.  
  
##  \<a name="agent__status_method">\</a>  agent::status Method  
 A synchronous source of status information from the agent.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Return Value  
 Returns the current state of the agent. Note that this returned state could change immediately after being returned.  
  
##  \<a name="agent__status_port_method">\</a>  agent::status_port Method  
 An asynchronous source of status information from the agent.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
### Return Value  
 Returns a message source that can send messages about the current state of the agent.  
  
##  \<a name="agent__wait_method">\</a>  agent::wait Method  
 Waits for an agent to complete its task.  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>48\</CodeContentPlaceHolder>  
 A pointer to the agent to wait for.  
  
 <CodeContentPlaceHolder>49\</CodeContentPlaceHolder>  
 The maximum time for which to wait, in milliseconds.  
  
### Return Value  
 The                         <CodeContentPlaceHolder>50\</CodeContentPlaceHolder> of the agent when the wait completes. This can either be                         <CodeContentPlaceHolder>51\</CodeContentPlaceHolder> or                         <CodeContentPlaceHolder>52\</CodeContentPlaceHolder>.  
  
### Remarks  
 An agent task is completed when the agent enters the                         <CodeContentPlaceHolder>53\</CodeContentPlaceHolder> or                         <CodeContentPlaceHolder>54\</CodeContentPlaceHolder> states.  
  
 If the parameter                         <CodeContentPlaceHolder>55\</CodeContentPlaceHolder> has a value other than the constant                         <CodeContentPlaceHolder>56\</CodeContentPlaceHolder>, the exception                         [operation_timed_out](../vs140/operation_timed_out-class.md) is thrown if the specified amount of time expires before the agent has completed its task.  
  
##  \<a name="agent__wait_for_all_method">\</a>  agent::wait_for_all Method  
 Waits for all of the specified agents to complete their tasks.  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>57\</CodeContentPlaceHolder>  
 The number of agent pointers present in the array                                 <CodeContentPlaceHolder>58\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>59\</CodeContentPlaceHolder>  
 An array of pointers to the agents to wait for.  
  
 <CodeContentPlaceHolder>60\</CodeContentPlaceHolder>  
 A pointer to an array of agent statuses. Each status value will represent the status of the corresponding agent when the method returns.  
  
 <CodeContentPlaceHolder>61\</CodeContentPlaceHolder>  
 The maximum time for which to wait, in milliseconds.  
  
### Remarks  
 An agent task is completed when the agent enters the                         <CodeContentPlaceHolder>62\</CodeContentPlaceHolder> or                         <CodeContentPlaceHolder>63\</CodeContentPlaceHolder> states.  
  
 If the parameter                         <CodeContentPlaceHolder>64\</CodeContentPlaceHolder> has a value other than the constant                         <CodeContentPlaceHolder>65\</CodeContentPlaceHolder>, the exception                         [operation_timed_out](../vs140/operation_timed_out-class.md) is thrown if the specified amount of time expires before the agent has completed its task.  
  
##  \<a name="agent__wait_for_one_method">\</a>  agent::wait_for_one Method  
 Waits for any one of the specified agents to complete its task.  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>66\</CodeContentPlaceHolder>  
 The number of agent pointers present in the array                                 <CodeContentPlaceHolder>67\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>68\</CodeContentPlaceHolder>  
 An array of pointers to the agents to wait for.  
  
 <CodeContentPlaceHolder>69\</CodeContentPlaceHolder>  
 A reference to a variable where the agent status will be placed.  
  
 <CodeContentPlaceHolder>70\</CodeContentPlaceHolder>  
 A reference to a variable where the agent index will be placed.  
  
 <CodeContentPlaceHolder>71\</CodeContentPlaceHolder>  
 The maximum time for which to wait, in milliseconds.  
  
### Remarks  
 An agent task is completed when the agent enters the                         <CodeContentPlaceHolder>72\</CodeContentPlaceHolder> or                         <CodeContentPlaceHolder>73\</CodeContentPlaceHolder> states.  
  
 If the parameter                         <CodeContentPlaceHolder>74\</CodeContentPlaceHolder> has a value other than the constant                         <CodeContentPlaceHolder>75\</CodeContentPlaceHolder>, the exception                         [operation_timed_out](../vs140/operation_timed_out-class.md) is thrown if the specified amount of time expires before the agent has completed its task.  
  
## See Also  
 [concurrency Namespace](../vs140/concurrency-namespace.md)