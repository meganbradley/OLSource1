---
title: "Asynchronous Message Blocks"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "non-greedy join [Concurrency Runtime]"
  - "asynchronous message blocks"
  - "greedy join [Concurrency Runtime]"
ms.assetid: 79c456c0-1692-480c-bb67-98f2434c1252
caps.latest.revision: 34
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Asynchronous Message Blocks
The Agents Library provides several message-block types that enable you to propagate messages among application components in a thread-safe manner. These message-block types are often used with the various message-passing routines, such as [concurrency::send](../vs140/send-function.md), [concurrency::asend](../vs140/asend-function.md), [concurrency::receive](../vs140/receive-function.md), and [concurrency::try_receive](../vs140/try_receive-function.md). For more information about the message passing routines that are defined by the Agents Library, see [Message Passing Functions](../vs140/message-passing-functions.md).  
  
##  \<a name="top">\</a> Sections  
 This topic contains the following sections:  
  
-   [Sources and Targets](#sources_and_targets)  
  
-   [Message Propagation](#propagation)  
  
-   [Overview of Message Block Types](#overview)  
  
-   [unbounded_buffer Class](#unbounded_buffer)  
  
-   [overwrite_buffer Class](#overwrite_buffer)  
  
-   [single_assignment Class](#single_assignment)  
  
-   [call Class](#call)  
  
-   [transformer Class](#transformer)  
  
-   [choice Class](#choice)  
  
-   [join and multitype_join Classes](#join)  
  
-   [timer Class](#timer)  
  
-   [Message Filtering](#filtering)  
  
-   [Message Reservation](#reservation)  
  
##  \<a name="sources_and_targets">\</a> Sources and Targets  
 Sources and targets are two important participants in message passing. A *source* refers to an endpoint of communication that sends messages. A *target* refers to an endpoint of communication that receives messages. You can think of a source as an endpoint that you read from and a target as an endpoint that you write to. Applications connect sources and targets together to form *messaging networks*.  
  
 The Agents Library uses two abstract classes to represent sources and targets: [concurrency::ISource](../vs140/isource-class.md) and [concurrency::ITarget](../vs140/itarget-class.md). Message block types that act as sources derive from <CodeContentPlaceHolder>0\</CodeContentPlaceHolder>; message block types that act as targets derive from <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>. Message block types that act as sources and targets derive from both <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>.  
  
 [[Top](#top)]  
  
##  \<a name="propagation">\</a> Message Propagation  
 *Message propagation* is the act of sending a message from one component to another. When a message block is offered a message, it can accept, decline, or postpone that message. Every message block type stores and transmits messages in different ways. For example, the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> class stores an unlimited number of messages, the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> class stores a single message at a time, and the transformer class stores an altered version of each message. These message block types are described in more detail later in this document.  
  
 When a message block accepts a message, it can optionally perform work and, if the message block is a source, pass the resulting message to another member of the network. A message block can use a filter function to decline messages that it does not want to receive. Filters are described in more detail later in this topic, in the section [Message Filtering](#filtering). A message block that postpones a message can reserve that message and consume it later. Message reservation is described in more detail later in this topic, in the section [Message Reservation](#reservation).  
  
 The Agents Library enables message blocks to asynchronously or synchronously pass messages. When you pass a message to a message block synchronously, for example, by using the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> function, the runtime blocks the current context until the target block either accepts or rejects the message. When you pass a message to a message block asynchronously, for example, by using the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> function, the runtime offers the message to the target, and if the target accepts the message, the runtime schedules an asynchronous task that propagates the message to the receiver. The runtime uses lightweight tasks to propagate messages in a cooperative manner. For more information about lightweight tasks, see [Task Scheduler (Concurrency Runtime)](../vs140/task-scheduler--concurrency-runtime-.md).  
  
 Applications connect sources and targets together to form messaging networks. Typically, you link the network and call <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> to pass data to the network. To connect a source message block to a target, call the [concurrency::ISource::link_target](../vs140/isource--link_target-method.md) method. To disconnect a source block from a target, call the [concurrency::ISource::unlink_target](../vs140/isource--unlink_target-method.md) method. To disconnect a source block from all of its targets, call the [concurrency::ISource::unlink_targets](../vs140/isource--unlink_targets-method.md) method. When one of the predefined message block types leaves scope or is destroyed, it automatically disconnects itself from any target blocks. Some message block types restrict the maximum number of targets that they can write to. The following section describes the restrictions that apply to the predefined message block types.  
  
 [[Top](#top)]  
  
##  \<a name="overview">\</a> Overview of Message Block Types  
 The following table briefly describes the role of the important message-block types.  
  
 [unbounded_buffer](#unbounded_buffer)  
 Stores a queue of messages.  
  
 [overwrite_buffer](#overwrite_buffer)  
 Stores one message that can be written to and read from multiple times.  
  
 [single_assignment](#single_assignment)  
 Stores one message that can be written to one time and read from multiple times.  
  
 [call](#call)  
 Performs work when it receives a message.  
  
 [transformer](#transformer)  
 Performs work when it receives data and sends the result of that work to another target block. The <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> class can act on different input and output types.  
  
 [choice](#choice)  
 Selects the first available message from a set of sources.  
  
 [join and multitype join](#join)  
 Wait for all messages to be received from a set of sources and then combine the messages into one message for another message block.  
  
 [timer](#timer)  
 Sends a message to a target block on a regular interval.  
  
 These message-block types have different characteristics that make them useful for different situations. These are some of the characteristics:  
  
-   *Propagation type*: Whether the message block acts as a source of data, a receiver of data, or both.  
  
-   *Message ordering*: Whether the message block maintains the original order in which messages are sent or received. Each predefined message block type maintains the original order in which it sends or receives messages.  
  
-   *Source count*: The maximum number of sources that the message block can read from.  
  
-   *Target count*: The maximum number of targets that the message block can write to.  
  
 The following table shows how these characteristics relate to the various message-block types.  
  
|Message block type|Propagation type (Source, Target, or Both)|Message ordering (Ordered or Unordered)|Source count|Target count|  
|------------------------|--------------------------------------------------|-----------------------------------------------|------------------|------------------|  
|<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>|Both|Ordered|Unbounded|Unbounded|  
|<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>|Both|Ordered|Unbounded|Unbounded|  
|<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>|Both|Ordered|Unbounded|Unbounded|  
|<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>|Target|Ordered|Unbounded|Not Applicable|  
|<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>|Both|Ordered|Unbounded|1|  
|<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>|Both|Ordered|10|1|  
|<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>|Both|Ordered|Unbounded|1|  
|<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>|Both|Ordered|10|1|  
|<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>|Source|Not Applicable|Not Applicable|1|  
  
 The following sections describe the message-block types in more detail.  
  
 [[Top](#top)]  
  
##  \<a name="unbounded_buffer">\</a> unbounded_buffer Class  
 The [concurrency::unbounded_buffer](../vs140/unbounded_buffer-class.md) class represents a general-purpose asynchronous messaging structure. This class stores a first in, first out (FIFO) queue of messages that can be written to by multiple sources or read from by multiple targets. When a target receives a message from an <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> object, that message is removed from the message queue. Therefore, although an <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> object can have multiple targets, only one target will receive each message. The <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> class is useful when you want to pass multiple messages to another component, and that component must receive each message.  
  
### Example  
 The following example shows the basic structure of how to work with the <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> class. This example sends three values to an <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> object and then reads those values back from the same object.  
  
 [!code[concrt-unbounded_buffer-structure#1](../vs140/codesnippet/CPP/asynchronous-message-blocks_1.cpp)]  
  
 This example produces the following output:  
  
 **334455** For a complete example that shows how to use the <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> class, see [How to: Implement Various Producer-Consumer Patterns](../vs140/how-to--implement-various-producer-consumer-patterns.md).  
  
 [[Top](#top)]  
  
##  \<a name="overwrite_buffer">\</a> overwrite_buffer Class  
 The [concurrency::overwrite_buffer](../vs140/overwrite_buffer-class.md) class resembles the <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> class, except that an <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> object stores just one message. In addition, when a target receives a message from an <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> object, that message is not removed from the buffer. Therefore, multiple targets receive a copy of the message.  
  
 The <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> class is useful when you want to pass multiple messages to another component, but that component needs only the most recent value. This class is also useful when you want to broadcast a message to multiple components.  
  
### Example  
 The following example shows the basic structure of how to work with the <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> class. This example sends three values to an <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> object and then reads the current value from the same object three times. This example is similar to the example for the <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> class. However, the <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> class stores just one message. In addition, the runtime does not remove the message from an <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> object after it is read.  
  
 [!code[concrt-overwrite_buffer-structure#1](../vs140/codesnippet/CPP/asynchronous-message-blocks_2.cpp)]  
  
 This example produces the following output:  
  
 **555555** For a complete example that shows how to use the <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> class, see [How to: Implement Various Producer-Consumer Patterns](../vs140/how-to--implement-various-producer-consumer-patterns.md).  
  
 [[Top](#top)]  
  
##  \<a name="single_assignment">\</a> single_assignment Class  
 The [concurrency::single_assignment](../vs140/single_assignment-class.md) class resembles the <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> class, except that a <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> object can be written to one time only. Like the <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> class, when a target receives a message from a <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> object, that message is not removed from that object. Therefore, multiple targets receive a copy of the message. The <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> class is useful when you want to broadcast one message to multiple components.  
  
### Example  
 The following example shows the basic structure of how to work with the <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> class. This example sends three values to a <CodeContentPlaceHolder>42\</CodeContentPlaceHolder> object and then reads the current value from the same object three times. This example is similar to the example for the <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> class. Although both the <CodeContentPlaceHolder>44\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>45\</CodeContentPlaceHolder> classes store a single message, the <CodeContentPlaceHolder>46\</CodeContentPlaceHolder> class can be written to one time only.  
  
 [!code[concrt-single_assignment-structure#1](../vs140/codesnippet/CPP/asynchronous-message-blocks_3.cpp)]  
  
 This example produces the following output:  
  
 **333333** For a complete example that shows how to use the <CodeContentPlaceHolder>47\</CodeContentPlaceHolder> class, see [Walkthrough: Implementing Futures](../vs140/walkthrough--implementing-futures.md).  
  
 [[Top](#top)]  
  
##  \<a name="call">\</a> call Class  
 The [concurrency::call](../vs140/call-class.md) class acts as a message receiver that performs a work function when it receives data. This work function can be a lambda expression, a function object, or a function pointer. A <CodeContentPlaceHolder>48\</CodeContentPlaceHolder> object behaves differently than an ordinary function call because it acts in parallel to other components that send messages to it. If a <CodeContentPlaceHolder>49\</CodeContentPlaceHolder> object is performing work when it receives a message, it adds that message to a queue. Every <CodeContentPlaceHolder>50\</CodeContentPlaceHolder> object processes queued messages in the order in which they are received.  
  
### Example  
 The following example shows the basic structure of how to work with the <CodeContentPlaceHolder>51\</CodeContentPlaceHolder> class. This example creates a <CodeContentPlaceHolder>52\</CodeContentPlaceHolder> object that prints each value that it receives to the console. The example then sends three values to the <CodeContentPlaceHolder>53\</CodeContentPlaceHolder> object. Because the <CodeContentPlaceHolder>54\</CodeContentPlaceHolder> object processes messages on a separate thread, this example also uses a counter variable and an [event](../vs140/event-class.md) object to ensure that the <CodeContentPlaceHolder>55\</CodeContentPlaceHolder> object processes all messages before the <CodeContentPlaceHolder>56\</CodeContentPlaceHolder> function returns.  
  
 [!code[concrt-call-structure#1](../vs140/codesnippet/CPP/asynchronous-message-blocks_4.cpp)]  
  
 This example produces the following output:  
  
 **334455** For a complete example that shows how to use the <CodeContentPlaceHolder>57\</CodeContentPlaceHolder> class, see [How to: Use the call Class](../vs140/how-to--provide-work-functions-to-the-call-and-transformer-classes.md).  
  
 [[Top](#top)]  
  
##  \<a name="transformer">\</a> transformer Class  
 The [concurrency::transformer](../vs140/transformer-class.md) class acts as both a message receiver and as a message sender. The <CodeContentPlaceHolder>58\</CodeContentPlaceHolder> class resembles the <CodeContentPlaceHolder>59\</CodeContentPlaceHolder> class because it performs a user-defined work function when it receives data. However, the <CodeContentPlaceHolder>60\</CodeContentPlaceHolder> class also sends the result of the work function to receiver objects. Like a <CodeContentPlaceHolder>61\</CodeContentPlaceHolder> object, a <CodeContentPlaceHolder>62\</CodeContentPlaceHolder> object acts in parallel to other components that send messages to it. If a <CodeContentPlaceHolder>63\</CodeContentPlaceHolder> object is performing work when it receives a message, it adds that message to a queue. Every <CodeContentPlaceHolder>64\</CodeContentPlaceHolder> object processes its queued messages in the order in which they are received.  
  
 The <CodeContentPlaceHolder>65\</CodeContentPlaceHolder> class sends its message to one target. If you set the <CodeContentPlaceHolder>66\</CodeContentPlaceHolder> parameter in the constructor to <CodeContentPlaceHolder>67\</CodeContentPlaceHolder>, you can later specify the target by calling the [concurrency::link_target](../vs140/source_block--link_target-method.md) method.  
  
 Unlike all other asynchronous message block types that are provided by the Agents Library, the <CodeContentPlaceHolder>68\</CodeContentPlaceHolder> class can act on different input and output types. This ability to transform data from one type to another makes the <CodeContentPlaceHolder>69\</CodeContentPlaceHolder> class a key component in many concurrent networks. In addition, you can add more fine-grained parallel functionality in the work function of a <CodeContentPlaceHolder>70\</CodeContentPlaceHolder> object.  
  
### Example  
 The following example shows the basic structure of how to work with the <CodeContentPlaceHolder>71\</CodeContentPlaceHolder> class. This example creates a <CodeContentPlaceHolder>72\</CodeContentPlaceHolder> object that multiples each input <CodeContentPlaceHolder>73\</CodeContentPlaceHolder> value by 0.33 in order to produce a <CodeContentPlaceHolder>74\</CodeContentPlaceHolder> value as output. The example then receives the transformed values from the same <CodeContentPlaceHolder>75\</CodeContentPlaceHolder> object and prints them to the console.  
  
 [!code[concrt-transformer-structure#1](../vs140/codesnippet/CPP/asynchronous-message-blocks_5.cpp)]  
  
 This example produces the following output:  
  
 **10.8914.5218.15** For a complete example that shows how to use the <CodeContentPlaceHolder>76\</CodeContentPlaceHolder> class, see [How to: Use transformer in a Data Pipeline](../vs140/how-to--use-transformer-in-a-data-pipeline.md).  
  
 [[Top](#top)]  
  
##  \<a name="choice">\</a> choice Class  
 The [concurrency::choice](../vs140/choice-class.md) class selects the first available message from a set of sources. The <CodeContentPlaceHolder>77\</CodeContentPlaceHolder> class represents a control-flow mechanism instead of a dataflow mechanism (the topic [Asynchronous Agents Library](../vs140/asynchronous-agents-library.md) describes the differences between dataflow and control-flow).  
  
 Reading from a choice object resembles calling the Windows API function <CodeContentPlaceHolder>78\</CodeContentPlaceHolder> when it has the <CodeContentPlaceHolder>79\</CodeContentPlaceHolder> parameter set to <CodeContentPlaceHolder>80\</CodeContentPlaceHolder>. However, the <CodeContentPlaceHolder>81\</CodeContentPlaceHolder> class binds data to the event itself instead of to an external synchronization object.  
  
 Typically, you use the <CodeContentPlaceHolder>82\</CodeContentPlaceHolder> class together with the [concurrency::receive](../vs140/receive-function.md) function to drive control-flow in your application. Use the <CodeContentPlaceHolder>83\</CodeContentPlaceHolder> class when you have to select among message buffers that have different types. Use the <CodeContentPlaceHolder>84\</CodeContentPlaceHolder> class when you have to select among message buffers that have the same type.  
  
 The order in which you link sources to a <CodeContentPlaceHolder>85\</CodeContentPlaceHolder> object is important because it can determine which message is selected. For example, consider the case where you link multiple message buffers that already contain a message to a <CodeContentPlaceHolder>86\</CodeContentPlaceHolder> object. The <CodeContentPlaceHolder>87\</CodeContentPlaceHolder> object selects the message from the first source that it is linked to. After you link all sources, the <CodeContentPlaceHolder>88\</CodeContentPlaceHolder> object preserves the order in which each source receives a message.  
  
### Example  
 The following example shows the basic structure of how to work with the <CodeContentPlaceHolder>89\</CodeContentPlaceHolder> class. This example uses the [concurrency::make_choice](../vs140/make_choice-function.md) function to create a <CodeContentPlaceHolder>90\</CodeContentPlaceHolder> object that selects among three message blocks. The example then computes various Fibonacci numbers and stores each result in a different message block. The example then prints to the console a message that is based on the operation that finished first.  
  
 [!code[concrt-choice-structure#1](../vs140/codesnippet/CPP/asynchronous-message-blocks_6.cpp)]  
  
 This example produces the following sample output:  
  
 **fib35 received its value first. Result = 9227465** Because the task that computes the 35<sup>th\</sup> Fibonacci number is not guaranteed to finish first, the output of this example can vary.  
  
 This example uses the [concurrency::parallel_invoke](../vs140/parallel_invoke-function.md) algorithm to compute the Fibonacci numbers in parallel. For more information about <CodeContentPlaceHolder>91\</CodeContentPlaceHolder>, see [Parallel Algorithms](../vs140/parallel-algorithms.md).  
  
 For a complete example that shows how to use the <CodeContentPlaceHolder>92\</CodeContentPlaceHolder> class, see [How to: Select Among Completed Tasks](../vs140/how-to--select-among-completed-tasks.md).  
  
 [[Top](#top)]  
  
##  \<a name="join">\</a> join and multitype_join Classes  
 The [concurrency::join](../vs140/join-class.md) and [concurrency::multitype_join](../vs140/multitype_join-class.md) classes let you wait for each member of a set of sources to receive a message. The <CodeContentPlaceHolder>93\</CodeContentPlaceHolder> class acts on source objects that have a common message type. The <CodeContentPlaceHolder>94\</CodeContentPlaceHolder> class acts on source objects that can have different message types.  
  
 Reading from a <CodeContentPlaceHolder>95\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>96\</CodeContentPlaceHolder> object resembles calling the Windows API function <CodeContentPlaceHolder>97\</CodeContentPlaceHolder> when it has the <CodeContentPlaceHolder>98\</CodeContentPlaceHolder> parameter set to <CodeContentPlaceHolder>99\</CodeContentPlaceHolder>. However, just like a <CodeContentPlaceHolder>100\</CodeContentPlaceHolder> object, <CodeContentPlaceHolder>101\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>102\</CodeContentPlaceHolder> objects use an event mechanism that binds data to the event itself instead of to an external synchronization object.  
  
 Reading from a <CodeContentPlaceHolder>103\</CodeContentPlaceHolder> object produces a [std::vector](../vs140/vector-class.md) object. Reading from a <CodeContentPlaceHolder>104\</CodeContentPlaceHolder> object produces a [std::tuple](../vs140/tuple-class.md) object. Elements appear in these objects in the same order as their corresponding source buffers are linked to the <CodeContentPlaceHolder>105\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>106\</CodeContentPlaceHolder> object. Because the order in which you link source buffers to a <CodeContentPlaceHolder>107\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>108\</CodeContentPlaceHolder> object is associated with the order of elements in the resulting <CodeContentPlaceHolder>109\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>110\</CodeContentPlaceHolder> object, we recommend that you do not unlink an existing source buffer from a join. Doing so can result in unspecified behavior.  
  
### Greedy Versus Non-Greedy Joins  
 The <CodeContentPlaceHolder>111\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>112\</CodeContentPlaceHolder> classes support the concept of greedy and non-greedy joins. A *greedy join* accepts a message from each of its sources as messages become available until all message are available. A *non-greedy join* receives messages in two phases. First, a non-greedy join waits until it is offered a message from each of its sources. Second, after all source messages are available, a non-greedy join attempts to reserve each of those messages. If it can reserve each message, it consumes all messages and propagates them to its target. Otherwise, it releases, or cancels, the message reservations and again waits for each source to receive a message.  
  
 Greedy joins perform better than non-greedy joins because they accept messages immediately. However, in rare cases, greedy joins can lead to deadlocks. Use a non-greedy join when you have multiple joins that contain one or more shared source objects.  
  
### Example  
 The following example shows the basic structure of how to work with the <CodeContentPlaceHolder>113\</CodeContentPlaceHolder> class. This example uses the [concurrency::make_join](../vs140/make_join-function.md) function to create a <CodeContentPlaceHolder>114\</CodeContentPlaceHolder> object that receives from three <CodeContentPlaceHolder>115\</CodeContentPlaceHolder> objects. This example computes various Fibonacci numbers, stores each result in a different <CodeContentPlaceHolder>116\</CodeContentPlaceHolder> object, and then prints to the console each result that the <CodeContentPlaceHolder>117\</CodeContentPlaceHolder> object holds. This example is similar to the example for the <CodeContentPlaceHolder>118\</CodeContentPlaceHolder> class, except that the <CodeContentPlaceHolder>119\</CodeContentPlaceHolder> class waits for all source message blocks to receive a message.  
  
 [!code[concrt-join-structure#1](../vs140/codesnippet/CPP/asynchronous-message-blocks_7.cpp)]  
  
 This example produces the following output:  
  
 **fib35 = 9227465fib37 = 24157817half_of_fib42 = 1.33957e+008** This example uses the [concurrency::parallel_invoke](../vs140/parallel_invoke-function.md) algorithm to compute the Fibonacci numbers in parallel. For more information about <CodeContentPlaceHolder>120\</CodeContentPlaceHolder>, see [Parallel Algorithms](../vs140/parallel-algorithms.md).  
  
 For complete examples that show how to use the <CodeContentPlaceHolder>121\</CodeContentPlaceHolder> class, see [How to: Select Among Completed Tasks](../vs140/how-to--select-among-completed-tasks.md) and [Walkthrough: Using join to Prevent Deadlock](../vs140/walkthrough--using-join-to-prevent-deadlock.md).  
  
 [[Top](#top)]  
  
##  \<a name="timer">\</a> timer Class  
 The [concurrency::timer](../vs140/timer-class.md) class acts as a message source. A <CodeContentPlaceHolder>122\</CodeContentPlaceHolder> object sends a message to a target after a specified period of time has elapsed. The <CodeContentPlaceHolder>123\</CodeContentPlaceHolder> class is useful when you must delay sending a message or you want to send a message at a regular interval.  
  
 The <CodeContentPlaceHolder>124\</CodeContentPlaceHolder> class sends its message to just one target. If you set the <CodeContentPlaceHolder>125\</CodeContentPlaceHolder> parameter in the constructor to <CodeContentPlaceHolder>126\</CodeContentPlaceHolder>, you can later specify the target by calling the [concurrency::ISource::link_target](../vs140/source_block--link_target-method.md) method.  
  
 A <CodeContentPlaceHolder>127\</CodeContentPlaceHolder> object can be repeating or non-repeating. To create a repeating timer, pass <CodeContentPlaceHolder>128\</CodeContentPlaceHolder> for the <CodeContentPlaceHolder>129\</CodeContentPlaceHolder> parameter when you call the constructor. Otherwise, pass <CodeContentPlaceHolder>130\</CodeContentPlaceHolder> for the <CodeContentPlaceHolder>131\</CodeContentPlaceHolder> parameter to create a non-repeating timer. If the timer is repeating, it sends the same message to its target after each interval.  
  
 The Agents Library creates <CodeContentPlaceHolder>132\</CodeContentPlaceHolder> objects in the non-started state. To start a timer object, call the [concurrency::timer::start](../vs140/timer--start-method.md) method. To stop a <CodeContentPlaceHolder>133\</CodeContentPlaceHolder> object, destroy the object or call the [concurrency::timer::stop](../vs140/timer--stop-method.md) method. To pause a repeating timer, call the [concurrency::timer::pause](../vs140/timer--pause-method.md) method.  
  
### Example  
 The following example shows the basic structure of how to work with the <CodeContentPlaceHolder>134\</CodeContentPlaceHolder> class. The example uses <CodeContentPlaceHolder>135\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>136\</CodeContentPlaceHolder> objects to report the progress of a lengthy operation.  
  
 [!code[concrt-timer-structure#1](../vs140/codesnippet/CPP/asynchronous-message-blocks_8.cpp)]  
  
 This example produces the following sample output:  
  
 **Computing fib(42)..................................................result is 267914296** For a complete example that shows how to use the <CodeContentPlaceHolder>137\</CodeContentPlaceHolder> class, see [How to: Send a Message at a Regular Interval](../vs140/how-to--send-a-message-at-a-regular-interval.md).  
  
 [[Top](#top)]  
  
##  \<a name="filtering">\</a> Message Filtering  
 When you create a message block object, you can supply a *filter function* that determines whether the message block accepts or rejects a message. A filter function is a useful way to guarantee that a message block receives only certain values.  
  
 The following example shows how to create an <CodeContentPlaceHolder>138\</CodeContentPlaceHolder> object that uses a filter function to accept only even numbers. The <CodeContentPlaceHolder>139\</CodeContentPlaceHolder> object rejects odd numbers, and therefore does not propagate odd numbers to its target blocks.  
  
 [!code[concrt-filter-function#1](../vs140/codesnippet/CPP/asynchronous-message-blocks_9.cpp)]  
  
 This example produces the following output:  
  
 **0 2 4 6 8** A filter function can be a lambda function, a function pointer, or a function object. Every filter function takes one of the following forms.  
  
 **bool (_Type)**  
**bool (_Type const &)** To eliminate the unnecessary copying of data, use the second form when you have an aggregate type that is propagated by value.  
  
 Message filtering supports the *dataflow* programming model, in which components perform computations when they receive data. For examples that use filter functions to control the flow of data in a message passing network, see [How to: Use a Message Block Filter to Improve Performance](../vs140/how-to--use-a-message-block-filter.md), [Walkthrough: Creating a Dataflow Agent](../vs140/walkthrough--creating-a-dataflow-agent.md), and [Walkthrough: Creating an Image-Processing Network](../vs140/walkthrough--creating-an-image-processing-network.md).  
  
 [[Top](#top)]  
  
##  \<a name="reservation">\</a> Message Reservation  
 *Message reservation* enables a message block to reserve a message for later use. Typically, message reservation is not used directly. However, understanding message reservation can help you better understand the behavior of some of the predefined message block types.  
  
 Consider non-greedy and greedy joins. Both of these use message reservation to reserve messages for later use. A described earlier, a non-greedy join receives messages in two phases. During the first phase, a non-greedy <CodeContentPlaceHolder>140\</CodeContentPlaceHolder> object waits for each of its sources to receive a message. A non-greedy join then attempts to reserve each of those messages. If it can reserve each message, it consumes all messages and propagates them to its target. Otherwise, it releases, or cancels, the message reservations and again waits for each source to receive a message.  
  
 A greedy join, which also reads input messages from a number of sources, uses message reservation to read additional messages while it waits to receive a message from each source. For example, consider a greedy join that receives messages from message blocks <CodeContentPlaceHolder>141\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>142\</CodeContentPlaceHolder>. If the greedy join receives two messages from B but has not yet received a message from <CodeContentPlaceHolder>143\</CodeContentPlaceHolder>, the greedy join saves the unique message identifier for the second message from <CodeContentPlaceHolder>144\</CodeContentPlaceHolder>. After the greedy join receives a message from <CodeContentPlaceHolder>145\</CodeContentPlaceHolder> and propagates out these messages, it uses the saved message identifier to see if the second message from <CodeContentPlaceHolder>146\</CodeContentPlaceHolder> is still available.  
  
 You can use message reservation when you implement your own custom message block types. For an example about how to create a custom message block type, see [Walkthrough: Creating a Custom Message Block](../vs140/walkthrough--creating-a-custom-message-block.md).  
  
 [[Top](#top)]  
  
## See Also  
 [Asynchronous Agents Library](../vs140/asynchronous-agents-library.md)