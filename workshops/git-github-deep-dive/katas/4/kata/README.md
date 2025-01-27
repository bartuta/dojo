DFDS Git Training - Code Kata #4
======================================

This training exercise is a **beginner-level** course on Git version control and serves as a starting point for developers looking to onboard our [Github.com](https://github.com/dfds) efforts.

## Getting started
These instructions will help you prepare for the kata and ensure that your training machine has the tools installed you will need to complete the assignment(s). If you find yourself in a situation where one or more tools might not be available for your training environment please reach out to your instructor for assistance on how to proceed, post an [issue in our repository](https://github.com/dfds/dojo/issues) or fix it yourself and update the kata via a [pull request](https://github.com/dfds/dojo/pulls).

### Prerequisites
* [Git](https://git-scm.com/downloads)

## Exercise
In our fourth exercise we will go through a simple example of branching and merging with a workflow that you might use in the real world. You’ll follow these steps:

1) Do some work.
2) Create a branch for a new user story you’re working on.
3) Do some work in that branch.

### 1. Create a kata directory
First we setup a directory for our exercise files. It's pretty straight forward:

```
mkdir kata4
cd kata4
```

### 2. Initialize a new repository
Create a new repository to serve a sandbox for our kata:

```
git init playing-with-branches
```

### 3. Add some changes to our "master" branch
Once we have initialized `playing-with-branches` we can proceed to "stage" a file and commit it to our `master` branch:

```
cd playing-with-branches
echo HelloFile > text.txt
git add .
git commit -m "Adding a file to main branch"
```

### 4. Create a new branch called "our-new-branch"
Once we have staged some changes in our `main` branch, lets try to create a new branch and see what happens:

```
git checkout -b our-new-branch
```

***Note*** <br/>
`git checkout -b our-new-branch` is shorthand for `git branch our-new-branch & git checkout our-new-branch`.

### 5. Add some changes to our "our-new-branch"
Once we have performed a checkout of `our-new-branch` we can proceed to "stage" a file and commit it:

```
echo HelloFile > text2.txt
git add .
git commit -m "Adding a file to our-new-branch branch"
```

### 6. Verify that "our-new-branch" is ahead of "master"
We can use the `git diff` command to verify that `our-new-branch` is ahead (+1) of `master`: 

```
git diff master our-new-branch
```

### 7. Merge changes from "our-new-branch" to "master"
Finally we can proceed to merge our changes from `our-new-branch` to `master`: 

```
git checkout master
git merge our-new-branch
```

### 8. Verify that "our-new-branch" is now aligned with "master"
We can use the `git diff` command again to verify that `our-new-branch` aligned with `master`: 

```
git diff master our-new-branch
```

## Want to help make our training material better?

 * Want to **log an issue** or **request a new kata**? Feel free to visit our [GitHub site](https://github.com/dfds/dojo/issues).
