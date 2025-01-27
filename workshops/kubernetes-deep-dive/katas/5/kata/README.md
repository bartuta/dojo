DFDS Kubernetes Training - Code kata #5
======================================

This training exercise is a **beginner-level** course on Kubernetes that serves as a starting point for developers looking get started with container orchestration at DFDS.

## Getting started
These instructions will help you prepare for the kata exercise and ensure that your local machine has the tools installed you will need to complete the assignment(s). If you find yourself in a situation where one or more tools might not be available for your training environment please reach out to your instructor for assistance on how to proceed, post an [issue in our repository](https://github.com/dfds/dojo/issues) or fix it yourself and create a [pull request](https://github.com/dfds/dojo/pulls).

### Prerequisites
* [Kubectl](https://kubernetes.io/docs/tasks/tools/install-kubectl/)
* [Docker](https://www.docker.com/products/docker-desktop)
* [Powershell Core](https://docs.microsoft.com/en-us/powershell/scripting/install/installing-powershell?view=powershell-6)

## Exercise
By default, Kubernetes pods have unrestricted network access both inside and outside the cluster. However it is often desirable to restrict network access to and from pods, particularly for security reasons, which has lead your team to identify a need to restrict access to the mysql pod and their precious data. Thankfully Kubernetes NetworkPolicies provide a flexible way to implement these networking restrictions, giving you control over all of the network traffic involving your pods. 


### 1. Create your kata directory
First we setup a directory for our exercise files. It's pretty straight forward:

```
mkdir kata5
cd kata5
```

### 2. Create a NetworkPolicy descriptor file to allocate some storage in our cluster
Create a file named "mysql-network-policy.yml" and add a NetworkPolicy definition:

```
apiVersion: networking.k8s.io/v1
kind: NetworkPolicy
metadata:
  name: mysql-network-policy
  namespace: default
spec:
  podSelector:
    matchLabels:
      app: db
  policyTypes:
  - Ingress
  ingress:
  - from:
    - podSelector:
        matchLabels:
          app: api
```

Just to explain: <br/>
`.kind: NetworkPolicy` - Specifies a need to create an object of kind (type) NetworkPolicy. <br/>
`.spec.podSelector: ...` -  A podSelector selects the grouping of pods to which a policy applies within a given namespace. The example policy selects pods with the label "app=db”. An empty podSelector selects all pods in the namespace.<br/>
`.spec.policyTypes: ...` -  The policyTypes field indicates whether or not the given policy applies to ingress traffic to selected pod, egress traffic from selected pods, or both.<br/>

### 3. Use kubectl to apply our new network policy
`kubectl apply -f mysql-network-policy.yml`

### 4. Use kubectl to examine the newly created network policy
`kubectl describe networkpolicy mysql-network-policy`

## Want to help make our training material better?
 * Want to **log an issue** or **request a new kata**? Feel free to visit our [GitHub site](https://github.com/dfds/dojo/issues). 