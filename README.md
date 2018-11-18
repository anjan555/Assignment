# Assignment - Anjan Plivo

SMS and Email test

This functional test framework is designed using C# , Selenium and Specflow.

To run the test :
------------------

Just clone this solution on the visual studio.
Navigate to test  -> Windows -> Explorer.
Right click and run the test.

Or

Use runtests.cmd file to run the test from command line.

If feature file is not recognised install "Specflow plugin" from Tools -> Extensions and update. [To run the test this is not required]

----------------------------------------------------------------------------------------------------------------------------------------
Framework capabilities :
-------------------------

There are three projects created :

1 : Plivo.Tests - This project contains Feature files and its stepdefinitions and test data in the form of tables.

2 : Plivo.SeleniumCore - This project contains core selenium utilities [wait, Action, Element visibility etc..] and Driver configuration.

3 : PlivoPages - This project contains page elements and its actions.

Project 2 and 3 are completely independent, as the framework matures these dlls can be added in mygetpackage and used with othre projects.

-----------------------------------------------------------------------------------------------------------------------------------------
Features of Framework:
-----------------------

1 : Tests can run on any browser based on App.config setting [As of now tested with IE and Chrome] - Currently configured with Chrome.

2 : This framework can be used with any unit-testframework based on App.config setting [As of now tested with Mstest and Specrun] - Currently configured with specrun.

3 : Tests can be run from command line as well using runtests.cmd file.

4 : Parallel test is based on configuration.

5 : Reports

a ) Default specrun report is generated.
b ) Added extent report, which can be used as both report and logging mechanism.
c ) Klov reporting with mongodb is used for trach historical test runs.
----------------------------------------------------------------------------------------------------------------------------------------



