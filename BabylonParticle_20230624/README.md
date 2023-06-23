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
#### パーティクルの実装
```javascript
let particleSystem = new BABYLON.ParticleSystem("sparkles", 1000, scene);
particleSystem.particleTexture = new BABYLON.Texture("https://cdn.jsdelivr.net/gh/capucat/blendermodels/flwr.png", scene);
```
#### パーティクルの開始
```javascript
particleSystem.emitter = sphere;
particleSystem.particleEmitterType = new BABYLON.SphereParticleEmitter();    
particleSystem.start();
```
#### 最後の一手間
```javascript
//球を不可視にする
sphere.isVisible = false;
```
### 4.パーティクル2:雨
#### パーティクル発生源になる球を生成
```javascript
BABYLON.ParticleHelper.CreateAsync("rain", scene, false).then((set) => {
        set.start();
});
```
### 5.パーティクル3:炎
#### レンダーパイプラインを使用する準備
```javascript
var pipeline = new BABYLON.DefaultRenderingPipeline("default", true, scene);
```
#### トーンマッピングの設定
```javascript
scene.imageProcessingConfiguration.toneMappingEnabled = true;
scene.imageProcessingConfiguration.toneMappingType = 
BABYLON.ImageProcessingConfiguration.TONEMAPPING_ACES;
scene.imageProcessingConfiguration.exposure = 1;
```
#### 炎のパーティクル
```javascript
BABYLON.ParticleHelper.CreateAsync("fire", scene).then((set) => {
    set.start();
});
```
#### ブルーム 
```javascript
pipeline.bloomEnabled = true;
pipeline.bloomThreshold = 0.8;
pipeline.bloomWeight = 1;
pipeline.bloomKernel = 64;
pipeline.bloomScale = 0.5;
```
<br>
<br>
<br>
