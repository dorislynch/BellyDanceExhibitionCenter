
# react-native-belly-dance-exhibition-center

## Getting started

`$ npm install react-native-belly-dance-exhibition-center --save`

### Mostly automatic installation

`$ react-native link react-native-belly-dance-exhibition-center`

### Manual installation


#### iOS

1. In XCode, in the project navigator, right click `Libraries` ➜ `Add Files to [your project's name]`
2. Go to `node_modules` ➜ `react-native-belly-dance-exhibition-center` and add `RNBellyDanceExhibitionCenter.xcodeproj`
3. In XCode, in the project navigator, select your project. Add `libRNBellyDanceExhibitionCenter.a` to your project's `Build Phases` ➜ `Link Binary With Libraries`
4. Run your project (`Cmd+R`)<

#### Android

1. Open up `android/app/src/main/java/[...]/MainActivity.java`
  - Add `import com.reactlibrary.RNBellyDanceExhibitionCenterPackage;` to the imports at the top of the file
  - Add `new RNBellyDanceExhibitionCenterPackage()` to the list returned by the `getPackages()` method
2. Append the following lines to `android/settings.gradle`:
  	```
  	include ':react-native-belly-dance-exhibition-center'
  	project(':react-native-belly-dance-exhibition-center').projectDir = new File(rootProject.projectDir, 	'../node_modules/react-native-belly-dance-exhibition-center/android')
  	```
3. Insert the following lines inside the dependencies block in `android/app/build.gradle`:
  	```
      compile project(':react-native-belly-dance-exhibition-center')
  	```

#### Windows
[Read it! :D](https://github.com/ReactWindows/react-native)

1. In Visual Studio add the `RNBellyDanceExhibitionCenter.sln` in `node_modules/react-native-belly-dance-exhibition-center/windows/RNBellyDanceExhibitionCenter.sln` folder to their solution, reference from their app.
2. Open up your `MainPage.cs` app
  - Add `using Belly.Dance.Exhibition.Center.RNBellyDanceExhibitionCenter;` to the usings at the top of the file
  - Add `new RNBellyDanceExhibitionCenterPackage()` to the `List<IReactPackage>` returned by the `Packages` method


## Usage
```javascript
import RNBellyDanceExhibitionCenter from 'react-native-belly-dance-exhibition-center';

// TODO: What to do with the module?
RNBellyDanceExhibitionCenter;
```
  