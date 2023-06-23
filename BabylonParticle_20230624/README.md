# Babylon.jsではじめるパーティクル表現
##演習用コード
### 1.テンプレートの複製
```javascript
https://glitch.com/~particle-test-simple-base
```
### 2.boxの追加
```javascript
const box = BABYLON.MeshBuilder.CreateBox("box");
```
### 3.パーティクル1:光
#### パーティクル発生源になる球を生成
```javascript
var sphere = BABYLON.MeshBuilder.CreateSphere("sparkles"); 
sphere.position = new BABYLON.Vector3(0, 0, 0); 
```
```javascript
//パーティクルの実装
let particleSystem = new BABYLON.ParticleSystem("sparkles", 1000, scene);
particleSystem.particleTexture = new BABYLON.Texture("https://cdn.jsdelivr.net/gh/capucat/blendermodels/flwr.png", scene);
```

```javascript
//パーティクルの開始
particleSystem.emitter = sphere;
particleSystem.particleEmitterType = new BABYLON.SphereParticleEmitter();    
particleSystem.start();
```



<br>
<br>
<br>
