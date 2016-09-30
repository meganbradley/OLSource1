---
title: "JavaScript Console commands"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-debug"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "FSharp"
  - "VB"
  - "CSharp"
  - "C++"
helpviewer_keywords: 
  - "JavaScript Console commands [Windows Store apps]"
  - "JavaScript debugging, console [Windows Store apps]"
  - "debugging JavaScript, console [Windows Store apps]"
ms.assetid: 359e2b24-6bb7-48e7-8b55-b570df0cb774
caps.latest.revision: 51
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# JavaScript Console commands
![Applies to Windows and Windows Phone](../vs140/media/windows_and_phone_content.png "windows_and_phone_content")  
  
 You can use commands to send messages and perform other tasks in the JavaScript Console window of Visual Studio. For examples that show how to use that window, see [Quick Start: Debugging JavaScript using the console](../vs140/quickstart--debug-javascript-using-the-console.md). The information in this topic applies to Windows Store apps, Windows Phone Store apps, and apps created using Visual Studio Tools for Apache Cordova. For info on supported console commands in Cordova apps, see [Debug your app](../vs140/debug-your-app-built-with-visual-studio-tools-for-apache-cordova.md). For info on using the console in Internet Explorer F12 tools, see [this topic](http://msdn.microsoft.com/library/ie/dn255006.aspx).  
  
 If the JavaScript Console window is closed, you can open it while you're debugging in Visual Studio by choosing **Debug** > **Windows** > **JavaScript Console**.  
  
> [!NOTE]
>  If the window is not available during a debugging session, make sure that the debugger type is set to **Script** in the Debug properties for the project.  
  
## console object commands  
 This table shows the syntax for the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> object commands that you can use in the JavaScript Console window, or that you can use to send messages to the console from your code. This object provides a number of forms so that you can distinguish between informational messages and error messages, if you want to.  
  
 You can use the longer command form <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> if you need to avoid possible confusion with local objects named console.  
  
> [!TIP]
>  Older versions of Visual Studio do not support the complete set of commands. Use IntelliSense on the console object to get quick information about supported commands.  
  
|Command|Description|Example|  
|-------------|-----------------|-------------|  
|<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>|Sends a message if <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> evaluates to **false**.|<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>|Clears messages from the console window, including script-error messages, and also clears script that appears in the console window. Does not clear script that you entered into the console input prompt.|<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>|Sends the number of times that the count command was called to the console window. Each call to count is uniquely identified by the optional <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>.\<br />\<br /> The existing entry in the console window is identified by the <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> parameter (if present) and updated by the count command. A new entry is not created.|<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>\<br />\<br /> <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>|Sends <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> to the console window.\<br />\<br /> This command is identical to console.log.\<br />\<br /> Objects that are passed by using the command are converted to a string value.|<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>|Sends the specified object to the console window and displays it in an object visualizer. You can use the visualizer to inspect properties in the console window.|<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>|Sends the specified XML node <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> to the console window and displays it as an XML node tree.|<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>|Sends <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> to the console window. The message text is red and prefaced by an error symbol.\<br />\<br /> Objects that are passed by using the command are converted to a string value.|<CodeContentPlaceHolder>25\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>26\</CodeContentPlaceHolder>|Starts a grouping for messages that are sent to the console window, and sends the optional <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> as a group label. Groups can be nested and appear in a tree view in the console window.\<br />\<br /> The group* commands can make it easier to view console window output in some scenarios, such as when a component model is in use.|<CodeContentPlaceHolder>28\</CodeContentPlaceHolder> \<br /> <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> \<br /> <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> \<br /> <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> \<br /> <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> \<br /> <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> \<br /> <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> \<br /> <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> \<br /> <CodeContentPlaceHolder>36\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>37\</CodeContentPlaceHolder>|Starts a grouping for messages that are sent to the console window, and sends the optional <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> as a group label. Groups that are sent by using <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> appear in a collapsed view by default. Groups can be nested and appear in a tree view in the console window.|Usage is the same as the <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> command.\<br />\<br /> See the example for the <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> command.|  
|<CodeContentPlaceHolder>42\</CodeContentPlaceHolder>|Ends the current group.\<br />\<br /> Requirements:\<br />\<br /> Visual Studio 2013|See the example for the <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> command.|  
|<CodeContentPlaceHolder>44\</CodeContentPlaceHolder>|Sends <CodeContentPlaceHolder>45\</CodeContentPlaceHolder> to the console window. The message is prefaced by an information symbol.|<CodeContentPlaceHolder>46\</CodeContentPlaceHolder>\<br />\<br /> For more examples, see [Formatting console.log output](#ConsoleLog) later in this topic.|  
|<CodeContentPlaceHolder>47\</CodeContentPlaceHolder>|Sends <CodeContentPlaceHolder>48\</CodeContentPlaceHolder> to the console window.\<br />\<br /> If you pass an object, this command sends that object to the console window and displays it in an object visualizer. You can use the visualizer to inspect properties in the console window.|<CodeContentPlaceHolder>49\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>50\</CodeContentPlaceHolder>|Used in web apps. Not supported in Store apps using JavaScript.|Not supported.|  
|<CodeContentPlaceHolder>51\</CodeContentPlaceHolder>|Used in web apps. Not supported in Store apps using JavaScript.|Not supported.|  
|<CodeContentPlaceHolder>52\</CodeContentPlaceHolder>|Used in web apps. Not supported in Store apps using JavaScript.|Not supported.|  
|<CodeContentPlaceHolder>53\</CodeContentPlaceHolder>|Selects the specified HTML <CodeContentPlaceHolder>54\</CodeContentPlaceHolder> in the [DOM Explorer](../vs140/quickstart--debug-html-and-css.md).|console.select(element);|  
|<CodeContentPlaceHolder>55\</CodeContentPlaceHolder>|Starts a timer that's identified by the optional <CodeContentPlaceHolder>56\</CodeContentPlaceHolder> parameter. When used with <CodeContentPlaceHolder>57\</CodeContentPlaceHolder>, calculates the time that elapses between <CodeContentPlaceHolder>58\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>59\</CodeContentPlaceHolder>, and sends the result (measured in ms) to the console using the <CodeContentPlaceHolder>60\</CodeContentPlaceHolder> string as a prefix. Used to enable instrumentation of app code for measuring performance.|<CodeContentPlaceHolder>61\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>62\</CodeContentPlaceHolder>|Stops a timer that's identified by the optional <CodeContentPlaceHolder>63\</CodeContentPlaceHolder> parameter. See the <CodeContentPlaceHolder>64\</CodeContentPlaceHolder> console command.|<CodeContentPlaceHolder>65\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>66\</CodeContentPlaceHolder>|Sends a stack trace to the console window. The trace includes the complete call stack, and includes info such as filename, line number, and column number.|<CodeContentPlaceHolder>67\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>68\</CodeContentPlaceHolder>|Sends <CodeContentPlaceHolder>69\</CodeContentPlaceHolder> to the console window, prefaced by a warning symbol.\<br />\<br /> Objects that are passed by using the command are converted to a string value.|<CodeContentPlaceHolder>70\</CodeContentPlaceHolder>|  
  
## Miscellaneous commands  
 These commands are also available in the JavaScript Console window (they are not available from code).  
  
|Command|Description|Example|  
|-------------|-----------------|-------------|  
|<CodeContentPlaceHolder>71\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>72\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>73\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>74\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>75\</CodeContentPlaceHolder>|Returns the specified element to the console window. <CodeContentPlaceHolder>76\</CodeContentPlaceHolder> returns the element currently selected in DOM Explorer, <CodeContentPlaceHolder>77\</CodeContentPlaceHolder> returns the element previously selected in DOM Explorer, and so on, up to the fourth previously selected element.|$3|  
|<CodeContentPlaceHolder>78\</CodeContentPlaceHolder>|Returns an element by ID. This is a shortcut command for <CodeContentPlaceHolder>79\</CodeContentPlaceHolder>, where <CodeContentPlaceHolder>80\</CodeContentPlaceHolder> is a string that represents the element ID.|<CodeContentPlaceHolder>81\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>82\</CodeContentPlaceHolder>|Returns an array of elements that match the specified selector using CSS selector syntax. This is a shortcut command for <CodeContentPlaceHolder>83\</CodeContentPlaceHolder>.|<CodeContentPlaceHolder>84\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>85\</CodeContentPlaceHolder>\<br />\<br /> <CodeContentPlaceHolder>86\</CodeContentPlaceHolder>|Enables you to change the context for expression evaluation from the default top-level window of the page to the window of the specified frame. Calling <CodeContentPlaceHolder>87\</CodeContentPlaceHolder> without parameters returns the context to the top-level window.|<CodeContentPlaceHolder>88\</CodeContentPlaceHolder>\<br />\<br /> <CodeContentPlaceHolder>89\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>90\</CodeContentPlaceHolder>|Selects the specified element in [DOM Explorer](../vs140/quickstart--debug-html-and-css.md).|<CodeContentPlaceHolder>91\</CodeContentPlaceHolder>\<br />\<br /> <CodeContentPlaceHolder>92\</CodeContentPlaceHolder>\<br />\<br /> <CodeContentPlaceHolder>93\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>94\</CodeContentPlaceHolder>|Returns a visualizer for the specified object. You can use the visualizer to inspect properties in the console window.|<CodeContentPlaceHolder>95\</CodeContentPlaceHolder>|  
  
## Checking whether a console command exists  
 You can check whether a specific command exists before attempting to use it. This example checks for the existence of the <CodeContentPlaceHolder>96\</CodeContentPlaceHolder> command. If <CodeContentPlaceHolder>97\</CodeContentPlaceHolder> exists, the code calls it.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Examining objects in the JavaScript Console window  
 You can interact with any object that's in scope when you use the JavaScript Console window. To inspect an out-of-scope object in the console window, use <CodeContentPlaceHolder>98\</CodeContentPlaceHolder> , <CodeContentPlaceHolder>99\</CodeContentPlaceHolder>, or other commands from your code. Alternatively, you can interact with the object from the console window while it is in scope by setting a breakpoint in your code (**Breakpoint** > **Insert Breakpoint**).  
  
##  \<a name="ConsoleLog">\</a> Formatting console.log output  
 If you pass multiple arguments to <CodeContentPlaceHolder>100\</CodeContentPlaceHolder>, the console will treat the arguments as an array and concatenate the output.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>101\</CodeContentPlaceHolder> also supports "printf" substitution patterns to format output. If you use substitution patterns in the first argument, additional arguments will be used to replace the specified patterns in the order they are used.  
  
 The following substitution patterns are supported:  
  
-   %s - string  
     %i - integer  
     %d - integer  
     %f - float  
     %o - object  
     %b - binary  
     %x - hexadecimal  
     %e - exponent  
  
 Here are some examples of using substitution patterns in <CodeContentPlaceHolder>102\</CodeContentPlaceHolder>:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## See Also  
 [QuickStart: Debug JavaScript using the console](../vs140/quickstart--debug-javascript-using-the-console.md)   
 [Quick Start: Debug HTML and CSS](../vs140/quickstart--debug-html-and-css.md)