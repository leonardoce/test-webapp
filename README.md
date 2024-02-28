# WebApp playground

## Basic authentication scenario

```
kubectl apply -f k8s/cluster-example.yaml
kubectl apply -f k8s/webapp.yaml
```

## mTLS authentication scenario

```
kubectl cnpg certificate --cnpg-cluster=cluster-example --cnpg-user=app cluster-example-app-mtls

kubectl apply -f k8s/cluster-example-mtls.yaml
kubectl apply -f k8s/webapp-mtls.yaml
```

## How to start the load generator

```
kubectl delete job load-generator --ignore-not-found=true
kubectl apply -f k8s/load-generator.yaml
```