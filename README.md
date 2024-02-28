# WebApp playgroud

## mTLS authentication

Step 1: create a mTLS authentication certificate with:

```
kubectl cnpg certificate --cnpg-cluster=cluster-example --cnpg-user=app cluster-example-app-mtls
```

Step 2: apply the resources as in:

```
kubectl apply -f k8s/cluster-example-mtls.yaml
kubectl apply -f k8s/webapp-mtls.yaml
```