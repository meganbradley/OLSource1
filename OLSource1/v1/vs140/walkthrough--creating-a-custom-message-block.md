---
title: "Walkthrough: Creating a Custom Message Block"
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
  - "creating custom message blocks Concurrency Runtime]"
  - "custom message blocks, creating [Concurrency Runtime]"
ms.assetid: 4c6477ad-613c-4cac-8e94-2c9e63cd43a1
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Walkthrough: Creating a Custom Message Block
This document describes how to create a custom message block type that orders incoming messages by priority.  
  
 Although the built-in message block types provide a wide-range of functionality, you can create your own message block type and customize it to meet the requirements of your application. For a description of the built-in message block types that are provided by the Asynchronous Agents Library, see [Asynchronous Message Blocks](../vs140/asynchronous-message-blocks.md).  
  
## Prerequisites  
 Read the following documents before you start this walkthrough:  
  
-   [Asynchronous Message Blocks](../vs140/asynchronous-message-blocks.md)  
  
-   [Message Passing Functions](../vs140/message-passing-functions.md)  
  
##  \<a name="top">\</a> Sections  
 This walkthrough contains the following sections:  
  
-   [Designing a Custom Message Block](#design)  
  
-   [Defining the priority_buffer Class](#class)  
  
-   [The Complete Example](#complete)  
  
##  \<a name="design">\</a> Designing a Custom Message Block  
 Message blocks participate in the act of sending and receiving messages. A message block that sends messages is known as a *source block*. A message block that receives messages is known as a *target block*. A message block that both sends and receives messages is known as a *propagator block*. The Agents Library uses the abstract class [concurrency::ISource](../vs140/isource-class.md) to represent source blocks and the abstract class [concurrency::ITarget](../vs140/itarget-class.md) to represent target blocks. Message block types that act as sources derive from <CodeContentPlaceHolder>0\</CodeContentPlaceHolder>; message block types that act as targets derive from <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>.  
  
 Although you can derive your message block type directly from <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>, the Agents Library defines three base classes that perform much of the functionality that is common to all message block types, for example, handling errors and connecting message blocks together in a concurrency-safe manner. The [concurrency::source_block](../vs140/source_block-class.md) class derives from <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> and sends messages to other blocks. The [concurrency::target_block](../vs140/target_block-class.md) class derives from <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> and receives messages from other blocks. The [concurrency::propagator_block](../vs140/propagator_block-class.md) class derives from <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> and sends messages to other blocks and it receives messages from other blocks. We recommend that you use these three base classes to handle infrastructure details so that you can focus on the behavior of your message block.  
  
 The <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> classes are templates that are parameterized on a type that manages the connections, or links, between source and target blocks and on a type that manages how messages are processed. The Agents Library defines two types that perform link management, [concurrency::single_link_registry](../vs140/single_link_registry-class.md) and [concurrency::multi_link_registry](../vs140/multi_link_registry-class.md). The <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> class enables a message block to be linked to one source or to one target. The <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> class enables a message block to be linked to multiple sources or multiple targets. The Agents Library defines one class that performs message management, [concurrency::ordered_message_processor](../vs140/ordered_message_processor-class.md). The <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> class enables message blocks to process messages in the order in which it receives them.  
  
 To better understand how message blocks relate to their sources and targets, consider the following example. This example shows the declaration of the [concurrency::transformer](../vs140/transformer-class.md) class.  
  
 [!code[concrt-priority-buffer#20](../vs140/codesnippet/CPP/walkthrough--creating-a-custom-message-block_1.cpp)]  
  
 The <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> class derives from <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>, and therefore acts as both a source block and as a target block. It accepts messages of type <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> and sends messages of type <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>. The <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> class specifies <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> as the link manager for any target blocks and <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> as the link manager for any source blocks. Therefore, a <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> object can have up to one target and an unlimited number of sources.  
  
 A class that derives from <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> must implement six methods: [propagate_to_any_targets](../vs140/source_block--propagate_to_any_targets-method.md), [accept_message](../vs140/source_block--accept_message-method.md), [reserve_message](../vs140/source_block--reserve_message-method.md), [consume_message](../vs140/source_block--consume_message-method.md), [release_message](../vs140/source_block--release_message-method.md), and [resume_propagation](../vs140/source_block--resume_propagation-method.md). A class that derives from <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> must implement the [propagate_message](../vs140/propagator_block--propagate_message-method.md) method and can optionally implement the [send_message](../vs140/propagator_block--send_message-method.md) method. Deriving from <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> is functionally equivalent to deriving from both <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>.  
  
 The <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> method is called by the runtime to asynchronously or synchronously process any incoming messages and propagate out any outgoing messages. The <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> method is called by target blocks to accept messages. Many message block types, such as <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>, send messages only to the first target that would receive it. Therefore, it transfers ownership of the message to the target. Other message block types, such as [concurrency::overwrite_buffer](../vs140/overwrite_buffer-class.md), offer messages to each of its target blocks. Therefore, <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> creates a copy of the message for each of its targets.  
  
 The <CodeContentPlaceHolder>31\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>32\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>33\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> methods enable message blocks to participate in message reservation. Target blocks call the <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> method when they are offered a message and have to reserve the message for later use. After a target block reserves a message, it can call the <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> method to consume that message or the <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> method to cancel the reservation. As with the <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> method, the implementation of <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> can either transfer ownership of the message or return a copy of the message. After a target block either consumes or releases a reserved message, the runtime calls the <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> method. Typically, this method continues message propagation, starting with the next message in the queue.  
  
 The runtime calls the <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> method to asynchronously transfer a message from another block to the current one. The <CodeContentPlaceHolder>42\</CodeContentPlaceHolder> method resembles <CodeContentPlaceHolder>43\</CodeContentPlaceHolder>, except that it synchronously, instead of asynchronously, sends the message to the target blocks. The default implementation of <CodeContentPlaceHolder>44\</CodeContentPlaceHolder> rejects all incoming messages. The runtime does not call either of these methods if the message does not pass the optional filter function that is associated with the target block. For more information about message filters, see [Asynchronous Message Blocks](../vs140/asynchronous-message-blocks.md).  
  
 [[Top](#top)]  
  
##  \<a name="class">\</a> Defining the priority_buffer Class  
 The <CodeContentPlaceHolder>45\</CodeContentPlaceHolder> class is a custom message block type that orders incoming messages first by priority, and then by the order in which messages are received. The <CodeContentPlaceHolder>46\</CodeContentPlaceHolder> class resembles the [concurrency::unbounded_buffer](../vs140/unbounded_buffer-class.md) class because it holds a queue of messages, and also because it acts as both a source and a target message block and can have both multiple sources and multiple targets. However, <CodeContentPlaceHolder>47\</CodeContentPlaceHolder> bases message propagation only on the order in which it receives messages from its sources.  
  
 The <CodeContentPlaceHolder>48\</CodeContentPlaceHolder> class receives messages of type [std::tuple](../vs140/tuple-class.md) that contain <CodeContentPlaceHolder>49\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>50\</CodeContentPlaceHolder> elements. <CodeContentPlaceHolder>51\</CodeContentPlaceHolder> refers to the type that holds the priority of each message; <CodeContentPlaceHolder>52\</CodeContentPlaceHolder> refers to the data portion of the message. The <CodeContentPlaceHolder>53\</CodeContentPlaceHolder> class sends messages of type <CodeContentPlaceHolder>54\</CodeContentPlaceHolder>. The <CodeContentPlaceHolder>55\</CodeContentPlaceHolder> class also manages two message queues: a [std::priority_queue](../vs140/priority_queue-class.md) object for incoming messages and a [std::queue](../vs140/queue-class.md) object for outgoing messages. Ordering messages by priority is useful when a <CodeContentPlaceHolder>56\</CodeContentPlaceHolder> object receives multiple messages simultaneously or when it receives multiple messages before any messages are read by consumers.  
  
 In addition to the seven methods that a class that derives from <CodeContentPlaceHolder>57\</CodeContentPlaceHolder> must implement, the <CodeContentPlaceHolder>58\</CodeContentPlaceHolder> class also overrides the <CodeContentPlaceHolder>59\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>60\</CodeContentPlaceHolder> methods. The <CodeContentPlaceHolder>61\</CodeContentPlaceHolder> class also defines two public helper methods, <CodeContentPlaceHolder>62\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>63\</CodeContentPlaceHolder>, and a private helper method, <CodeContentPlaceHolder>64\</CodeContentPlaceHolder>.  
  
 The following procedure describes how to implement the <CodeContentPlaceHolder>65\</CodeContentPlaceHolder> class.  
  
#### To define the priority_buffer class  
  
1.  Create a C++ header file and name it <CodeContentPlaceHolder>66\</CodeContentPlaceHolder>. Alternatively, you can use an existing header file that is part of your project.  
  
2.  In <CodeContentPlaceHolder>67\</CodeContentPlaceHolder>, add the following code.  
  
     [!code[concrt-priority-buffer#1](../vs140/codesnippet/CPP/walkthrough--creating-a-custom-message-block_2.h)]  
  
3.  In the <CodeContentPlaceHolder>68\</CodeContentPlaceHolder> namespace, define specializations of [std::less](../vs140/less-struct.md) and [std::greater](../vs140/greater-struct.md) that act on [concurrency::message](../vs140/message-class.md) objects.  
  
     [!code[concrt-priority-buffer#2](../vs140/codesnippet/CPP/walkthrough--creating-a-custom-message-block_3.h)]  
  
     The <CodeContentPlaceHolder>69\</CodeContentPlaceHolder> class stores <CodeContentPlaceHolder>70\</CodeContentPlaceHolder> objects in a <CodeContentPlaceHolder>71\</CodeContentPlaceHolder> object. These type specializations enable the priority queue to sort messages according to their priority. The priority is the first element of the <CodeContentPlaceHolder>72\</CodeContentPlaceHolder> object.  
  
4.  In the <CodeContentPlaceHolder>73\</CodeContentPlaceHolder> namespace, declare the <CodeContentPlaceHolder>74\</CodeContentPlaceHolder> class.  
  
     [!code[concrt-priority-buffer#3](../vs140/codesnippet/CPP/walkthrough--creating-a-custom-message-block_4.h)]  
  
     The <CodeContentPlaceHolder>75\</CodeContentPlaceHolder> class derives from <CodeContentPlaceHolder>76\</CodeContentPlaceHolder>. Therefore, it can both send and receive messages. The <CodeContentPlaceHolder>77\</CodeContentPlaceHolder> class can have multiple targets that receive messages of type <CodeContentPlaceHolder>78\</CodeContentPlaceHolder>. It can also have multiple sources that send messages of type <CodeContentPlaceHolder>79\</CodeContentPlaceHolder>.  
  
5.  In the <CodeContentPlaceHolder>80\</CodeContentPlaceHolder> section of the <CodeContentPlaceHolder>81\</CodeContentPlaceHolder> class, add the following member variables.  
  
     [!code[concrt-priority-buffer#6](../vs140/codesnippet/CPP/walkthrough--creating-a-custom-message-block_5.h)]  
  
     The <CodeContentPlaceHolder>82\</CodeContentPlaceHolder> object holds incoming messages; the <CodeContentPlaceHolder>83\</CodeContentPlaceHolder> object holds outgoing messages. A <CodeContentPlaceHolder>84\</CodeContentPlaceHolder> object can receive multiple messages simultaneously; the <CodeContentPlaceHolder>85\</CodeContentPlaceHolder> object synchronizes access to the queue of input messages.  
  
6.  In the <CodeContentPlaceHolder>86\</CodeContentPlaceHolder> section, define the copy constructor and the assignment operator. This prevents <CodeContentPlaceHolder>87\</CodeContentPlaceHolder> objects from being assignable.  
  
     [!code[concrt-priority-buffer#7](../vs140/codesnippet/CPP/walkthrough--creating-a-custom-message-block_6.h)]  
  
7.  In the <CodeContentPlaceHolder>88\</CodeContentPlaceHolder> section, define the constructors that are common to many message block types. Also define the destructor.  
  
     [!code[concrt-priority-buffer#4](../vs140/codesnippet/CPP/walkthrough--creating-a-custom-message-block_7.h)]  
  
8.  In the <CodeContentPlaceHolder>89\</CodeContentPlaceHolder> section, define the methods <CodeContentPlaceHolder>90\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>91\</CodeContentPlaceHolder>. These helper methods provide an alternative way to send messages to and receive messages from a <CodeContentPlaceHolder>92\</CodeContentPlaceHolder> object.  
  
     [!code[concrt-priority-buffer#5](../vs140/codesnippet/CPP/walkthrough--creating-a-custom-message-block_8.h)]  
  
9. In the <CodeContentPlaceHolder>93\</CodeContentPlaceHolder> section, define the <CodeContentPlaceHolder>94\</CodeContentPlaceHolder> method.  
  
     [!code[concrt-priority-buffer#9](../vs140/codesnippet/CPP/walkthrough--creating-a-custom-message-block_9.h)]  
  
     The <CodeContentPlaceHolder>95\</CodeContentPlaceHolder> method transfers the message that is at the front of the input queue to the output queue and propagates out all messages in the output queue.  
  
10. In the <CodeContentPlaceHolder>96\</CodeContentPlaceHolder> section, define the <CodeContentPlaceHolder>97\</CodeContentPlaceHolder> method.  
  
     [!code[concrt-priority-buffer#8](../vs140/codesnippet/CPP/walkthrough--creating-a-custom-message-block_10.h)]  
  
     When a target block calls the <CodeContentPlaceHolder>98\</CodeContentPlaceHolder> method, the <CodeContentPlaceHolder>99\</CodeContentPlaceHolder> class transfers ownership of the message to the first target block that accepts it. (This resembles the behavior of <CodeContentPlaceHolder>100\</CodeContentPlaceHolder>.)  
  
11. In the <CodeContentPlaceHolder>101\</CodeContentPlaceHolder> section, define the <CodeContentPlaceHolder>102\</CodeContentPlaceHolder> method.  
  
     [!code[concrt-priority-buffer#10](../vs140/codesnippet/CPP/walkthrough--creating-a-custom-message-block_11.h)]  
  
     The <CodeContentPlaceHolder>103\</CodeContentPlaceHolder> class permits a target block to reserve a message when the provided message identifier matches the identifier of the message that is at the front of the queue. In other words, a target can reserve the message if the <CodeContentPlaceHolder>104\</CodeContentPlaceHolder> object has not yet received an additional message and has not yet  propagated out the current one.  
  
12. In the <CodeContentPlaceHolder>105\</CodeContentPlaceHolder> section, define the <CodeContentPlaceHolder>106\</CodeContentPlaceHolder> method.  
  
     [!code[concrt-priority-buffer#11](../vs140/codesnippet/CPP/walkthrough--creating-a-custom-message-block_12.h)]  
  
     A target block calls <CodeContentPlaceHolder>107\</CodeContentPlaceHolder> to transfer ownership of the message that it reserved.  
  
13. In the <CodeContentPlaceHolder>108\</CodeContentPlaceHolder> section, define the <CodeContentPlaceHolder>109\</CodeContentPlaceHolder> method.  
  
     [!code[concrt-priority-buffer#12](../vs140/codesnippet/CPP/walkthrough--creating-a-custom-message-block_13.h)]  
  
     A target block calls <CodeContentPlaceHolder>110\</CodeContentPlaceHolder> to cancel its reservation to a message.  
  
14. In the <CodeContentPlaceHolder>111\</CodeContentPlaceHolder> section, define the <CodeContentPlaceHolder>112\</CodeContentPlaceHolder> method.  
  
     [!code[concrt-priority-buffer#13](../vs140/codesnippet/CPP/walkthrough--creating-a-custom-message-block_14.h)]  
  
     The runtime calls <CodeContentPlaceHolder>113\</CodeContentPlaceHolder> after a target block either consumes or releases a reserved message. This method propagates out any messages that are in the output queue.  
  
15. In the <CodeContentPlaceHolder>114\</CodeContentPlaceHolder> section, define the <CodeContentPlaceHolder>115\</CodeContentPlaceHolder> method.  
  
     [!code[concrt-priority-buffer#14](../vs140/codesnippet/CPP/walkthrough--creating-a-custom-message-block_15.h)]  
  
     The <CodeContentPlaceHolder>116\</CodeContentPlaceHolder> member variable is defined by the base class, <CodeContentPlaceHolder>117\</CodeContentPlaceHolder>. This member variable points to the target block, if any, that is holding a reservation to the message that is at the front of the output queue. The runtime calls <CodeContentPlaceHolder>118\</CodeContentPlaceHolder> when a new target is linked to the <CodeContentPlaceHolder>119\</CodeContentPlaceHolder> object. This method propagates out any messages that are in the output queue if no target is holding a reservation.  
  
16. In the <CodeContentPlaceHolder>120\</CodeContentPlaceHolder> section, define the <CodeContentPlaceHolder>121\</CodeContentPlaceHolder> method.  
  
     [!code[concrt-priority-buffer#15](../vs140/codesnippet/CPP/walkthrough--creating-a-custom-message-block_16.h)]  
  
     This method propagates out all messages from the output queue. Every message in the queue is offered to every target block until one of the target blocks accepts the message. The <CodeContentPlaceHolder>122\</CodeContentPlaceHolder> class preserves the order of the outgoing messages. Therefore, the first message in the output queue must be accepted by a target block before this method offers any other message to the target blocks.  
  
17. In the <CodeContentPlaceHolder>123\</CodeContentPlaceHolder> section, define the <CodeContentPlaceHolder>124\</CodeContentPlaceHolder> method.  
  
     [!code[concrt-priority-buffer#16](../vs140/codesnippet/CPP/walkthrough--creating-a-custom-message-block_17.h)]  
  
     The <CodeContentPlaceHolder>125\</CodeContentPlaceHolder> method enables the <CodeContentPlaceHolder>126\</CodeContentPlaceHolder> class to act as a message receiver, or target. This method receives the message that is offered by the provided source block and inserts that message into the priority queue. The <CodeContentPlaceHolder>127\</CodeContentPlaceHolder> method then asynchronously sends all output messages to the target blocks.  
  
     The runtime calls this method when you call the [concurrency::asend](../vs140/asend-function.md) function or when the message block is connected to other message blocks.  
  
18. In the <CodeContentPlaceHolder>128\</CodeContentPlaceHolder> section, define the <CodeContentPlaceHolder>129\</CodeContentPlaceHolder> method.  
  
     [!code[concrt-priority-buffer#17](../vs140/codesnippet/CPP/walkthrough--creating-a-custom-message-block_18.h)]  
  
     The <CodeContentPlaceHolder>130\</CodeContentPlaceHolder> method resembles <CodeContentPlaceHolder>131\</CodeContentPlaceHolder>. However it sends the output messages synchronously instead of asynchronously.  
  
     The runtime calls this method during a synchronous send operation, such as when you call the [concurrency::send](../vs140/send-function.md) function.  
  
 The <CodeContentPlaceHolder>132\</CodeContentPlaceHolder> class contains constructor overloads that are typical in many message block types. Some constructor overloads take [concurrency::Scheduler](../vs140/scheduler-class.md) or [concurrency::ScheduleGroup](../vs140/schedulegroup-class.md) objects, which enable the message block to be managed by a specific task scheduler. Other constructor overloads take a filter function. Filter functions enable message blocks to accept or reject a message on the basis of its payload. For more information about message filters, see [Asynchronous Message Blocks](../vs140/asynchronous-message-blocks.md). For more information about task schedulers, see [Task Scheduler (Concurrency Runtime)](../vs140/task-scheduler--concurrency-runtime-.md).  
  
 Because the <CodeContentPlaceHolder>133\</CodeContentPlaceHolder> class orders messages by priority and then by the order in which messages are received, this class is most useful when it receives messages asynchronously, for example, when you call the [concurrency::asend](../vs140/asend-function.md) function or when the message block is connected to other message blocks.  
  
 [[Top](#top)]  
  
##  \<a name="complete">\</a> The Complete Example  
 The following example shows the complete definition of the <CodeContentPlaceHolder>134\</CodeContentPlaceHolder> class.  
  
 [!code[concrt-priority-buffer#18](../vs140/codesnippet/CPP/walkthrough--creating-a-custom-message-block_19.h)]  
  
 The following example concurrently performs a number of <CodeContentPlaceHolder>135\</CodeContentPlaceHolder> and [concurrency::receive](../vs140/receive-function.md) operations on a <CodeContentPlaceHolder>136\</CodeContentPlaceHolder> object.  
  
 [!code[concrt-priority-buffer#19](../vs140/codesnippet/CPP/walkthrough--creating-a-custom-message-block_20.cpp)]  
  
 This example produces the following sample output.  
  
 **36 36 36 36 36 36 36 36 36 36 36 36 36 36 36 36 36 36 36 36 36 36 36 36 36**  
**24 24 24 24 24 24 24 24 24 24 24 24 24 24 24 24 24 24 24 24 24 24 24 24 24**  
**12 12 12 12 12 12 12 12 12 12 12 12 12 12 12 12 12 12 12 12 12 12 12 12 12** The <CodeContentPlaceHolder>137\</CodeContentPlaceHolder> class orders messages first by priority and then by the order in which it receives messages. In this example, messages with greater numerical priority are inserted towards the front of the queue.  
  
 [[Top](#top)]  
  
## Compiling the Code  
 Copy the example code and paste it in a Visual Studio project, or paste the definition of the <CodeContentPlaceHolder>138\</CodeContentPlaceHolder> class in a file that is named <CodeContentPlaceHolder>139\</CodeContentPlaceHolder> and the test program in a file that is named <CodeContentPlaceHolder>140\</CodeContentPlaceHolder> and then run the following command in a Visual Studio Command Prompt window.  
  
 **cl.exe /EHsc priority_buffer.cpp**  
  
## See Also  
 [Concurrency Runtime Walkthroughs](../vs140/concurrency-runtime-walkthroughs.md)   
 [Asynchronous Message Blocks](../vs140/asynchronous-message-blocks.md)   
 [Message Passing Functions](../vs140/message-passing-functions.md)