unit testing =\> unit of the application integration testing =\> with
external dependencies E2E =\> with selenium on UI testing

=============== test pyramid ======= ==========\> E2E ========\>
integration testing ======\> unit testing

Unit tests are great for quickly testing the logic of conditional
statements and loops. If you have methods with complex logic and
calculation, you should test them with your unit tests.

You might have an application that simply reads some data from or writes
it to a database. In that case you may need more integration tests than
unit tests.

\*\*\*\*\*\*\*\*\* testing frameworks \*\*\*\*\*\*\*\*\*

==== Nunit ==== ==== MSTest ==== ==== xUnit ====

All these frameworks give you a utility library to write your tests and
a test runner which runs your tests and gives you a report of passing
and failing tests. Which framework is better?

\*\*\*\*\*\*\*\*\*\* packages for NUnit \*\*\*\*\*\*\*\*\*\*

\#install-package NUnit -Version 3.8.1 \#Install-Package
nUnit3TestAdapter -Version 3.8.0

We need this package to run NUnit tests, inside Visual Studio, because
by default, the test runner that is built into Visual Studio, only
recognizes MS Tests.

------------------------------------------------------------------------

Test-driven development or TDD.

Test-driven development, or TDD, also called test first, is an approach
to build software. With TDD, you write your test before writing the
application or production code.

\*\*\*\*\*\*\*\*\*\*\* how can we test a code \*\*\*\*\*\*\*\*\*\*\*

==\> writing a failing test ==\> write the simplest application code to
make the test pass. ==\> refactor if necessary

you haven't written, chances are you have the same question. So, let's
see how TDD works.

You start by writing a failing test. This test should fail because you
don't have any application code that would make it pass, right?

Then you will write the simplest application code that will make this
test pass.

The absolute simplest, you don't want to over engineer here, you don't
want to design a class diagram with a zillion classes and methods. Use
the simplest implementation that would make the test pass.

Then, refactor your code if necessary.

These three steps are the foundation of TDD. You repeat these three
steps over and over until you build a complete feature.

\*\*\*\*\*\*\*\* Benefits of TDD \*\*\*\*\*\*\*\*

source code will be testable right from the get go.

You don't have to make any changes to your code to make it testable.

Second, is that every line of your production code is fully covered by
tests. Which means you can refactor and deploy with confidence,

and third, is that it often results in a simpler implementation.

When you start with a big class diagram.

Chances are you are over engineering and making the solution more
complex. If you write enough code to make all the tests pass, and that
solution works, there is no reason to write more code. The fact that all
your tests passed, means

you have fulfilled all the business requirements.

So, unless there is a new requirement, you don't need to write new code.
And if there is a new requirement, you start with failing test. So this
is TDD.

\*\*\*\*\*\*\*\*\*\*\* Set up and tear Down \*\*\*\*\*\*\*\*\*\*\*

So let me show you a cleaner way, to rewrite these tests. In NUnit we
have two special attributes.

SetUp and TearDown.

You can create a method here, and decorate it with a SetUp attribute and
then NUnit test runner will call that method before running each test.

And this is a great opportunity for us to initialize our math object.
Similarly, if we create a method and decorate it with the TearDown
attribute, NUnit test runner will call that method after each test.

Now in this course we're not going to use a TearDown attribute, because
this is often used with integration tests, because in your integration
tests, you may create some data in your database, and then you want to
do cleanup after each test. That's where we use the TearDown attribute,
so in this lecture, let me show you how to use the SetUp attribute to
rewrite these tests, and make them cleaner.

------------------------------------------------------------------------

------------------------------------------------------------------------

------------------------------------------------------------------------

I told you about two types of functions in programming. We have query
functions that return some value and command functions which are
supposed to perform an action.

A void function by definition is a command function. These command
functions often change some kind of

////////////////////////////////////////////////////////////////////

We can inject dependencies via method parameters, by properties, and by
constructors.

////////////////////////////////////////////////////////////////////
\*\*\*\*\*\*\*\*\*\*\*\*\*\*\*\*\*\*\*\*\*\*\*\*\*\*\*\*\*\*\*\*\*
issues with method parameters

1)  if you use method in many place and suddenly you add parameter to it
    then you have to change it everywhere.

2)  dependency injection frameworks can not inject dependencies via
    method parameters.

There are quite a few dependency injection frameworks out there, every
team loves a different framework.

So depending on the dependency injection framework you use in your team,
this approach may or may not work for you.

So I'm going to show you a second way to inject dependency. Instead of
injecting the dependency as a method parameter, we can inject it using a
property. So I'm going to declare a property of type IFileReader and
call it FileReader.

3)  you learned how to inject dependencies using properties. This
    approach works in a lot of scenarios, but some dependency injection
    frameworks can't inject dependencies via properties. So an
    alternative way is to inject dependencies via constructor
    parameters.

------------------------------------------------------------------------

------------------------------------------------------------------------

\*\*\*\*\*\*\*\*\*\*\* Dependency injection framework
\*\*\*\*\*\*\*\*\*\*\*\*\*\*
\*\*\*\*\*\*\*\*\*\*\*\*\*\*\*\*\*\*\*\*\*\*\*\*\*\*\*\*\*\*\*\*\*\*\*\*\*\*\*\*\*\*\*\*\*\*\*\*\*\*\*\*\*\*\*\*\*
\*\*\*\*\*\*\*\*\*\*\*\*\*\*\*\*\*\*\*\*\*\*\*\*\*\*\*\*\*\*\*\*\*\*\*\*\*\*\*\*\*\*\*\*\*\*\*\*\*\*\*\*\*\*\*\*\*

==\> NInject ==\> Structuremap ==\> Spring.net ==\> Autofac ==\> unity

==================== mocking framework =================
================= for fake objects ================

==\> Moq ==\> NSubstitute ==\> FakeItEasy ==\> Rhino Mocks
