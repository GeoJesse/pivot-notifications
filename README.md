
# react-native-pivot-notifications

## Getting started

`$ npm install react-native-pivot-notifications --save`

### Mostly automatic installation

`$ react-native link react-native-pivot-notifications`

### Manual installation


#### iOS

1. In XCode, in the project navigator, right click `Libraries` ➜ `Add Files to [your project's name]`
2. Go to `node_modules` ➜ `react-native-pivot-notifications` and add `RNPivotNotifications.xcodeproj`
3. In XCode, in the project navigator, select your project. Add `libRNPivotNotifications.a` to your project's `Build Phases` ➜ `Link Binary With Libraries`
4. Run your project (`Cmd+R`)<

#### Android

1. Open up `android/app/src/main/java/[...]/MainActivity.java`
  - Add `import com.reactlibrary.RNPivotNotificationsPackage;` to the imports at the top of the file
  - Add `new RNPivotNotificationsPackage()` to the list returned by the `getPackages()` method
2. Append the following lines to `android/settings.gradle`:
  	```
  	include ':react-native-pivot-notifications'
  	project(':react-native-pivot-notifications').projectDir = new File(rootProject.projectDir, 	'../node_modules/react-native-pivot-notifications/android')
  	```
3. Insert the following lines inside the dependencies block in `android/app/build.gradle`:
  	```
      compile project(':react-native-pivot-notifications')
  	```

#### Windows
[Read it! :D](https://github.com/ReactWindows/react-native)

1. In Visual Studio add the `RNPivotNotifications.sln` in `node_modules/react-native-pivot-notifications/windows/RNPivotNotifications.sln` folder to their solution, reference from their app.
2. Open up your `MainPage.cs` app
  - Add `using Pivot.Notifications.RNPivotNotifications;` to the usings at the top of the file
  - Add `new RNPivotNotificationsPackage()` to the `List<IReactPackage>` returned by the `Packages` method


## Usage
```javascript
import RNPivotNotifications from 'react-native-pivot-notifications';

// TODO: What to do with the module?
RNPivotNotifications;
```
  