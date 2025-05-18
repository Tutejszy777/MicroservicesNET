# Kubernetes commands

## Apply
kubectl apply -f platform-depl.yaml
kubectl apply -f command-depl.yaml
kubectl apply -f platform-ndport-service.yaml
kubectl apply -f ingress-srv.yaml
kubectl apply -f local-pvc.yaml
kubectl apply -f mssql-plat-depl.yaml

## delete
kubectl delete deployment platform-depl

## update image
kubectl rollout restart deployment platform-depl

## Ingress Nginx
kubectl apply -f https://raw.githubusercontent.com/kubernetes/ingress-nginx/controller-v1.12.2/deploy/static/provider/aws/deploy.yaml


## view
kubectl get deployments
kubectl get pods
kubectl get services
kubcetl get pvc
kubectl get storageclass

## secrets
kubectl create secret generic mssql --from-literal=SA_PASSWORD="Patrik123"

# host file 

cd C:\Windows\System32\drivers\etc changed