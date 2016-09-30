---
title: "How To: Create a Data-Driven Unit Test"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-devops-test"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "vs.test.testresults.unittest.datadriven"
  - "vs.test.testresults.unittest.datadriven.failure"
helpviewer_keywords: 
  - "unit tests, running"
  - "unit tests, data-driven"
  - "data-driven unit tests"
ms.assetid: a0322bc5-02c8-4f9f-af43-100a60b1bd28
caps.latest.revision: 37
ms.author: "mlearned"
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# How To: Create a Data-Driven Unit Test
Using the Microsoft unit test framework for managed code, you can set up a unit test method to retrieve values used in the test method from a data source. The method is run successively for each row in the data source, which makes it easy to test a variety of input by using a single method.  
  
 This topic contains the following sections:  
  
-   [The method under test](../vs140/how-to--create-a-data-driven-unit-test.md#BKMK_The_method_under_test)  
  
-   [Creating a data source](../vs140/how-to--create-a-data-driven-unit-test.md#BKMK_Creating_a_data_source)  
  
-   [Adding a TestContext to the test class](../vs140/how-to--create-a-data-driven-unit-test.md#BKMK_Adding_a_TestContext_to_the_test_class)  
  
-   [Writing the test method](../vs140/how-to--create-a-data-driven-unit-test.md#BKMK_Writing_the_test_method)  
  
    -   [Specifying the DataSourceAttribute](../vs140/how-to--create-a-data-driven-unit-test.md#BKMK_Specifying_the_DataSourceAttribute)  
  
    -   [Using TestContext.DataRow to access the data](../vs140/how-to--create-a-data-driven-unit-test.md#BKMK_Using_TestContext_DataRow_to_access_the_data)  
  
-   [Running the test and viewing results](../vs140/how-to--create-a-data-driven-unit-test.md#BKMK_Running_the_test_and_viewing_results)  
  
 Creating a data-driven unit test involves the following steps:  
  
1.  Create a data source that contains the values that you use in the test method. The data source can be any type that is registered on the machine that runs the test.  
  
2.  Add a private \<xref:Microsoft.VisualStudio.TestTools.UnitTesting.TestContext*> field and a public <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> property to the test class.  
  
3.  Create a unit test method and add a \<xref:Microsoft.VisualStudio.TestTools.UnitTesting.DataSourceAttribute*> attribute to it.  
  
4.  Use the \<xref:Microsoft.VisualStudio.TestTools.UnitTesting.TestContext.DataRow*> indexer property to retrieve the values that you use in a test.  
  
##  \<a name="BKMK_The_method_under_test">\</a> The method under test  
 As an example, let's assume that we have created:  
  
1.  A solution called <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> that accepts and processes transactions for different types of accounts.  
  
2.  A project in <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> called <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> that manages the transactions for accounts.  
  
3.  A class called <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> in the <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> project that performs the mathematical functions to ensure that any transaction is advantageous to the bank.  
  
4.  A unit test project called <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> to test the behavior of the <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> component.  
  
5.  A unit test class called <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> to verify the behavior of the <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> class.  
  
 We will test a method in <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> that adds two integers using a loop:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
##  \<a name="BKMK_Creating_a_data_source">\</a> Creating a data source  
 To test the <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> method, we create a data source that specifies a range of values for the parameters and the sum that you expect to be returned. In our example, we create a Sql Compact database named <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> and a table named <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> that contains the following column names and values  
  
|FirstNumber|SecondNumber|Sum|  
|-----------------|------------------|---------|  
|0|1|1|  
|1|1|2|  
|2|-3|-1|  
  
##  \<a name="BKMK_Adding_a_TestContext_to_the_test_class">\</a> Adding a TestContext to the test class  
 The unit test framework creates a <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> object to store the data source information for a data-driven test. The framework then sets this object as the value of the <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> property that we create.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 In your test method, you access the data through the <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> indexer property of the <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>.  
  
##  \<a name="BKMK_Writing_the_test_method">\</a> Writing the test method  
 The test method for <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> is fairly simple. For each row in the data source, we call <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> with the **FirstNumber** and **SecondNumber** column values as parameters, and we verify the return value against **Sum** column value:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Note that the <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> method includes a message that displays the <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> values of a failed iteration. By default, the asserted values, <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>32\</CodeContentPlaceHolder>, are already included in the details of a failed test.  
  
###  \<a name="BKMK_Specifying_the_DataSourceAttribute">\</a> Specifying the DataSourceAttribute  
 The <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> attribute specifies the connection string for the data source and the name of the table that you use in the test method. The exact information in the connection string differs, depending on what kind of data source you are using. In this example, we used a SqlServerCe database.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The DataSource attribute has three constructors.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 A constructor with one parameter uses connection information that is stored in the app.config file for the solution. The *dataSourceSettingsName* is the name of the Xml element in the config file that specifies the connection information.  
  
 Using an app.config file allows you to change the location of the data source without making changes to the unit test itself. For information about how to create and use an app.config file, see [Walkthrough: Using a Configuration File to Define a Data Source](../vs140/walkthrough--using-a-configuration-file-to-define-a-data-source.md)  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 The <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> constructor with two parameters specifies the connection string for the data source and the name of the table that contains the data for the test method.  
  
 The connection strings depend on the type of the type of data source, but it should contain a Provider element that specifies the invariant name of the data provider.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
###  \<a name="BKMK_Using_TestContext_DataRow_to_access_the_data">\</a> Using TestContext.DataRow to access the data  
 To access the data in the <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> table, use the <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> indexer. <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> is a \<xref:System.Data.DataRow*> object, so we retrieve column values by index or column names. Because the values are returned as objects, we need to convert them to the appropriate type:  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
##  \<a name="BKMK_Running_the_test_and_viewing_results">\</a> Running the test and viewing results  
 When you have finished writing a test method, build the test project. The test method appears in the Test Explorer window in the **Not Run Tests** group. As you run, write, and rerun your tests, Test Explorer displays the results in groups of **Failed Tests**, **Passed Tests**, and **Not Run Tests**. You can choose **Run All** to run all your tests, or choose **Run...** to choose a subset of tests to run.  
  
 The test results bar at the top of the Explorer is animated as your test runs. At the end of the test run, the bar will be green if all of the tests have passed or red if any of the tests have failed. A summary of the test run appears in the details pane at the bottom of the Test Explorer window. Select a test to view the details of that test in the bottom pane.  
  
 If you ran the <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> method in our example, the results bar turns red and the test method is moved to the **Failed Tests** A data-driven test fails if any of the iterated methods from the data source fails. When you choose a failed data-driven test in the Test Explorer window, the details pane displays the results of each iteration that is identified by the data row index. In our example, it appears that the <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> algorithm does not handle negative values correctly.  
  
 When the method under test is corrected and the test rerun, the results bar turns green and the test method is moved to the **Passed Test** group.  
  
## See Also  
 \<xref:Microsoft.VisualStudio.TestTools.UnitTesting.DataSourceAttribute*?displayProperty=fullName>   
 \<xref:Microsoft.VisualStudio.TestTools.UnitTesting.TestContext*?displayProperty=fullName>   
 \<xref:Microsoft.VisualStudio.TestTools.UnitTesting.TestContext.DataRow*?displayProperty=fullName>   
 \<xref:Microsoft.VisualStudio.TestTools.UnitTesting.Assert*?displayProperty=fullName>   
 [How to: Create and Run a Unit Test](assetId:///5e0f43cf-5e51-48e2-9c98-0eb9324bdc48)   
 [Verifying Code by Using Unit Tests](../vs140/unit-test-your-code.md)   
 [Running Unit Tests with Test Explorer](../vs140/run-unit-tests-with-test-explorer.md)   
 [Writing unit tests for .NET with the Microsoft Unit Test Framework for Managed Code](../vs140/writing-unit-tests-for-the-.net-framework-with-the-microsoft-unit-test-framework-for-managed-code.md)